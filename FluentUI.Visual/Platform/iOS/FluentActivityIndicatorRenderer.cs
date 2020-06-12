using System;
using FluentUIComponents;
using FluentUI.Visual.Platform.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using FluentVisual = FluentUI.Visual.Forms.FluentVisual;
using System.ComponentModel;
using FluentUI.Visual.Forms;

[assembly: ExportRenderer(typeof(ActivityIndicator), typeof(FluentActivityIndicatorRenderer), new[] { typeof(FluentVisual) })]

namespace FluentUI.Visual.Platform.iOS
{
    public class FluentActivityIndicatorRenderer : ViewRenderer<ActivityIndicator, MSFActivityIndicatorView>
    {

        protected override void OnElementChanged(ElementChangedEventArgs<ActivityIndicator> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    SetNativeControl(CreateNativeControl());
                }

                UpdateIsRunning();
                UpdateSpinnerColor();
                UpdateSpinnerSizeStyle();
            }
        }

        protected override MSFActivityIndicatorView CreateNativeControl() =>
            new MSFActivityIndicatorView(MSFActivityIndicatorViewSize.Medium);

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == ActivityIndicator.IsRunningProperty.PropertyName)
                UpdateIsRunning();
            if (e.PropertyName == ActivityIndicator.ColorProperty.PropertyName)
                UpdateSpinnerColor();
            if (e.PropertyName == FluentActivityIndicator.ActivityIndicatorStyleProperty.PropertyName)
                UpdateSpinnerSizeStyle();
        }

        private void UpdateSpinnerColor() => Control.Color = Element.Color.ToUIColor();

        private void UpdateIsRunning()
        {
            if (Element.IsRunning)
                Control.StartAnimating();
            else
                Control.StopAnimating();
        }

        private void UpdateSpinnerSizeStyle()
        {
            if (Control != null)
            {
                var style = FluentActivityIndicator.GetActivityIndicatorStyle(Element);
                var newStyle = MSFActivityIndicatorViewSize.Medium;
                switch (style)
                {
                    case FluentSpinnerStyle.XSmall:
                        newStyle = MSFActivityIndicatorViewSize.XSmall;
                        break;
                    case FluentSpinnerStyle.Small:
                        newStyle = MSFActivityIndicatorViewSize.Small;
                        break;
                    case FluentSpinnerStyle.Medium:
                        newStyle = MSFActivityIndicatorViewSize.Medium;
                        break;
                    case FluentSpinnerStyle.Large:
                        newStyle = MSFActivityIndicatorViewSize.Large;
                        break;
                    case FluentSpinnerStyle.XLarge:
                        newStyle = MSFActivityIndicatorViewSize.XLarge;
                        break;
                }
                ((MSFActivityIndicatorView)Control).Size = newStyle;
            }
        }
    }
}
