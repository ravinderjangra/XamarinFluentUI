using System;
using FluentUIComponents;
using FluentUI.Visual.Platform.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using FluentVisual = FluentUI.Visual.Forms.FluentVisual;
using System.Drawing;
using Foundation;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(DatePicker), typeof(FluentDatePickerRenderer), new[] { typeof(FluentVisual) })]

namespace FluentUI.Visual.Platform.iOS
{
    public class FluentDatePickerRenderer : DatePickerRenderer
    {
        MSFDateTimePicker _picker;
		DateTimePickerDelegate _delegate;
		NSDate _startDate;
		NSDate _endDate;
		IElementController ElementController => Element as IElementController;

		protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
		{
			//base.OnElementChanged(e);

			if (e.NewElement == null)
				return;

			if (Control == null)
			{
				var entry = CreateNativeControl();
				entry.EditingDidBegin += OnStarted;
				entry.EditingDidEnd += OnEnded;
				entry.Text = "Select date";

                var tapGesture = new UITapGestureRecognizer(
					() => ShowDatePicker())
                {
                    NumberOfTapsRequired = 1
                };

                entry.AddGestureRecognizer(tapGesture);
				_picker = new MSFDateTimePicker();
				_delegate = new DateTimePickerDelegate(this);
				_picker.Delegate = _delegate;
				SetNativeControl(entry);
			}

			UpdateMaximumDate();
			UpdateMinimumDate();
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (e.PropertyName == DatePicker.MinimumDateProperty.PropertyName)
				UpdateMinimumDate();
			else if (e.PropertyName == DatePicker.MaximumDateProperty.PropertyName)
				UpdateMaximumDate();
		}

		void UpdateMaximumDate() => _endDate = Element.MaximumDate.ToNSDate();

		void UpdateMinimumDate() => _startDate = Element.MinimumDate.ToNSDate();

		void OnEnded(object sender, EventArgs eventArgs)
		{
			ElementController.SetValueFromRenderer(VisualElement.IsFocusedPropertyKey, false);
		}

		void OnStarted(object sender, EventArgs eventArgs)
		{
			ElementController.SetValueFromRenderer(VisualElement.IsFocusedPropertyKey, true);
		}

		void ShowDatePicker()
        {
			var presentingController = GetTopViewController(UIApplication.SharedApplication.KeyWindow.RootViewController);
			_picker.PresentFrom(presentingController, MSFDateTimePickerMode.MSFDateTimePickerModeDate, _startDate, _endDate, MSFDateTimePickerDatePickerType.Calendar, MSFDateTimePickerDateRangePresentation.Paged, null);
		}

		protected UIViewController GetTopViewController(UIViewController viewController)
		{
			if (viewController is UINavigationController navigationController)
				return GetTopViewController(navigationController.VisibleViewController);

			if (viewController is UITabBarController tabBarController)
				return GetTopViewController(tabBarController.SelectedViewController);

			if (viewController.PresentedViewController != null)
				return GetTopViewController(viewController.PresentedViewController);

			return viewController;
		}

		void UpdateElementDate()
		{
			ElementController.SetValueFromRenderer(DatePicker.DateProperty, DateTime.Now.ToString());
		}

		protected override UITextField CreateNativeControl()
		{
            return new NoCaretField { BorderStyle = UITextBorderStyle.RoundedRect };
		}
	}

	internal class DateTimePickerDelegate : MSFDateTimePickerDelegate
    {
		readonly FluentDatePickerRenderer _renderer;

		public DateTimePickerDelegate(FluentDatePickerRenderer renderer)
		{
			if (renderer == null)
				throw new ArgumentNullException("renderer");
			_renderer = renderer;
		}

		public override void DidPickStartDate(MSFDateTimePicker dateTimePicker, NSDate startDate, NSDate endDate)
        {
			_renderer.Control.Text = startDate.ToDateTime().ToString();
		}

		public override bool ShouldEndPickingStartDate(MSFDateTimePicker dateTimePicker, NSDate startDate, NSDate endDate)
		{
			if (startDate.Compare(_renderer.Element.MinimumDate.ToNSDate()) == NSComparisonResult.Ascending)
				return false;

			if (endDate.Compare(_renderer.Element.MaximumDate.ToNSDate()) == NSComparisonResult.Descending)
				return false;

			return true;
		}
	}

	internal class NoCaretField : UITextField
	{
		public NoCaretField() : base(new RectangleF())
		{
			SpellCheckingType = UITextSpellCheckingType.No;
			AutocorrectionType = UITextAutocorrectionType.No;
			AutocapitalizationType = UITextAutocapitalizationType.None;
		}
	}
}
