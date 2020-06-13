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

[assembly: ExportRenderer(typeof(TimePicker), typeof(FluentTimePickerRenderer), new[] { typeof(FluentVisual) })]

namespace FluentUI.Visual.Platform.iOS
{
    public class FluentTimePickerRenderer : TimePickerRenderer
    {
		MSFDateTimePicker _picker;
		TimePickerDelegate _delegate;
		IElementController ElementController => Element as IElementController;

		protected override void OnElementChanged(ElementChangedEventArgs<TimePicker> e)
		{
			//base.OnElementChanged(e);

			if (e.NewElement == null)
				return;

			if (Control == null)
			{
				var entry = CreateNativeControl();
				entry.EditingDidBegin += OnStarted;
				entry.EditingDidEnd += OnEnded;
				entry.Text = "Select time";

				var tapGesture = new UITapGestureRecognizer(
					() => ShowDatePicker())
				{
					NumberOfTapsRequired = 1
				};

				entry.AddGestureRecognizer(tapGesture);
				_picker = new MSFDateTimePicker();
				_delegate = new TimePickerDelegate(this);
				_picker.Delegate = _delegate;
				SetNativeControl(entry);
			}
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);
		}

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
			var presentingController = PlatformUtils.GetTopViewController();
			_picker.PresentFrom(presentingController, MSFDateTimePickerMode.Time, NSDate.Now, null, MSFDateTimePickerDatePickerType.Components, MSFDateTimePickerDateRangePresentation.Paged, null);
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

	internal class TimePickerDelegate : MSFDateTimePickerDelegate
	{
		readonly FluentTimePickerRenderer _renderer;

		public TimePickerDelegate(FluentTimePickerRenderer renderer)
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
			return true;
		}
	}
}
