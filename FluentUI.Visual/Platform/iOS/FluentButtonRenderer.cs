using System;
using FluentUIComponents;
using FluentUI.Visual.Platform.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using FluentVisual = FluentUI.Visual.Forms.FluentVisual;
using System.ComponentModel;
using FluentUI.Visual.Forms;

[assembly: ExportRenderer(typeof(Button), typeof(FluentButtonRenderer), new[] { typeof(FluentVisual) })]

namespace FluentUI.Visual.Platform.iOS
{
    public class FluentButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
                UpdateButtonStyle();
        }

        protected override UIButton CreateNativeControl()
        {
            var style = MSFButtonStyle.PrimaryFilled;
            return new MSFButton(style);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == FluentButton.ButtonStyleProperty.PropertyName)
                UpdateButtonStyle();
        }

        private void UpdateButtonStyle()
        {
            if (Control != null)
            {
                var style = FluentButton.GetButtonStyle(Element);
                var newStyle = MSFButtonStyle.PrimaryFilled;
                switch (style)
                {
                    case FluentButtonStyle.PrimaryFilled:
                        newStyle = MSFButtonStyle.PrimaryFilled;
                        break;
                    case FluentButtonStyle.PrimaryOutLine:
                        newStyle = MSFButtonStyle.PrimaryOutline;
                        break;
                    case FluentButtonStyle.SecondaryOutLine:
                        newStyle = MSFButtonStyle.SecondaryOutline;
                        break;
                    case FluentButtonStyle.TertiaryOutline:
                        newStyle = MSFButtonStyle.TertiaryOutline;
                        break;
                    case FluentButtonStyle.Borderless:
                        newStyle = MSFButtonStyle.Borderless;
                        break;
                }
                ((MSFButton)Control).Style = newStyle;
            }
        }
    }
}
