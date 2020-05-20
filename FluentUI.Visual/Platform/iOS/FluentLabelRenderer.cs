using System.ComponentModel;
using FluentUIComponents;
using FluentUI.Visual.Forms;
using FluentUI.Visual.Platform.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using FluentVisual = FluentUI.Visual.Forms.FluentVisual;
using UIKit;

[assembly: ExportRenderer(typeof(Label), typeof(FluentLabelRenderer), new[] { typeof(FluentVisual) })]

namespace FluentUI.Visual.Platform.iOS
{
    public class FluentLabelRenderer : LabelRenderer
    {
        protected override UILabel CreateNativeControl()
        {
            return new MSFLabel(MSFTextStyle.Body, MSFTextColorStyle.Regular);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                UpdateLabelColorStyle();
                UpdateLabelTextStyle();
                UpdateLabelWeightStyle();
            }
        }

        // Todo: Implement this
        private void UpdateLabelWeightStyle()
        {
            if (Control != null)
            {
                var style = FluentLabel.GetLabelWeightStyle(Element);
                switch (style)
                {
                    case FluentLabelWeightStyle.Bold:
                        break;
                    case FluentLabelWeightStyle.Semibold:
                        break;
                    case FluentLabelWeightStyle.Medium:
                        break;
                    case FluentLabelWeightStyle.Regular:
                        break;
                }
            }
        }

        private void UpdateLabelTextStyle()
        {
            if (Control != null)
            {
                var style = FluentLabel.GetLabelTextStyle(Element);
                var newStyle = MSFTextStyle.Body;
                switch (style)
                {
                    case FluentLabelTextStyle.LargeTitle:
                        newStyle = MSFTextStyle.LargeTitle;
                        break;
                    case FluentLabelTextStyle.Title1:
                        newStyle = MSFTextStyle.Title1;
                        break;
                    case FluentLabelTextStyle.Title2:
                        newStyle = MSFTextStyle.Title2;
                        break;
                    case FluentLabelTextStyle.Headline:
                        newStyle = MSFTextStyle.Headline;
                        break;
                    case FluentLabelTextStyle.HeadlineUnscaled:
                        newStyle = MSFTextStyle.HeadlineUnscaled;
                        break;
                    case FluentLabelTextStyle.Body:
                        newStyle = MSFTextStyle.Body;
                        break;
                    case FluentLabelTextStyle.BodyUnscaled:
                        newStyle = MSFTextStyle.BodyUnscaled;
                        break;
                    case FluentLabelTextStyle.Subhead:
                        newStyle = MSFTextStyle.Subhead;
                        break;
                    case FluentLabelTextStyle.Footnote:
                        newStyle = MSFTextStyle.Footnote;
                        break;
                    case FluentLabelTextStyle.FootnodeUnscaled:
                        newStyle = MSFTextStyle.FootnoteUnscaled;
                        break;
                    case FluentLabelTextStyle.Button1:
                        newStyle = MSFTextStyle.Button1;
                        break;
                    case FluentLabelTextStyle.Button2:
                        newStyle = MSFTextStyle.Button2;
                        break;
                    case FluentLabelTextStyle.Button3:
                        newStyle = MSFTextStyle.Button3;
                        break;
                    case FluentLabelTextStyle.Caption1:
                        newStyle = MSFTextStyle.Caption1;
                        break;
                    case FluentLabelTextStyle.Caption2:
                        newStyle = MSFTextStyle.Caption2;
                        break;
                }
                ((MSFLabel)Control).Style = newStyle;
            }
        }

        private void UpdateLabelColorStyle()
        {
            if (Control != null)
            {
                var style = FluentLabel.GetLabelColorStyle(Element);
                var newStyle = MSFTextColorStyle.Regular;
                switch (style)
                {
                    case FluentLabelColorStyle.Regular:
                        newStyle = MSFTextColorStyle.Regular;
                        break;
                    case FluentLabelColorStyle.Secondary:
                        newStyle = MSFTextColorStyle.Secondary;
                        break;
                    case FluentLabelColorStyle.White:
                        newStyle = MSFTextColorStyle.White;
                        break;
                    case FluentLabelColorStyle.Primary:
                        newStyle = MSFTextColorStyle.Primary;
                        break;
                    case FluentLabelColorStyle.Error:
                        newStyle = MSFTextColorStyle.Error;
                        break;
                    case FluentLabelColorStyle.Warning:
                        newStyle = MSFTextColorStyle.Warning;
                        break;
                    case FluentLabelColorStyle.Disabled:
                        newStyle = MSFTextColorStyle.Disabled;
                        break;
                }
                ((MSFLabel)Control).ColorStyle = newStyle;
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == FluentLabel.LabelColorStyleProperty.PropertyName)
                UpdateLabelColorStyle();
            else if (e.PropertyName == FluentLabel.LabelWeightStyleProperty.PropertyName)
                UpdateLabelWeightStyle();
            else if (e.PropertyName == FluentLabel.LabelTextStyleProperty.PropertyName)
                UpdateLabelTextStyle();
        }
    }
}
