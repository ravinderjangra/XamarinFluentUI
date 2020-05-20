using System;
using Xamarin.Forms;

namespace FluentUI.Visual.Forms
{
    public static class FluentLabel
    {
        public static readonly BindableProperty LabelTextStyleProperty =
            BindableProperty.CreateAttached(
                "LabelTextStyle",
                typeof(FluentLabelTextStyle),
                typeof(Label),
                FluentLabelTextStyle.Body);

        public static readonly BindableProperty LabelColorStyleProperty =
            BindableProperty.CreateAttached(
                "LabelColorStyle",
                typeof(FluentLabelColorStyle),
                typeof(Label),
                FluentLabelColorStyle.Regular);

        public static readonly BindableProperty LabelWeightStyleProperty =
            BindableProperty.CreateAttached(
                "LabelWeightStyle",
                typeof(FluentLabelWeightStyle),
                typeof(Label),
                FluentLabelWeightStyle.Regular);

        public static FluentLabelTextStyle GetLabelTextStyle(BindableObject view)
        {
            return (FluentLabelTextStyle)view.GetValue(LabelTextStyleProperty);
        }

        public static void SetLabelTextStyle(BindableObject view, FluentLabelTextStyle value)
        {
            view.SetValue(LabelTextStyleProperty, value);
        }

        public static FluentLabelColorStyle GetLabelColorStyle(BindableObject view)
        {
            return (FluentLabelColorStyle)view.GetValue(LabelColorStyleProperty);
        }

        public static void SetLabelColorStyle(BindableObject view, FluentLabelColorStyle value)
        {
            view.SetValue(LabelColorStyleProperty, value);
        }

        public static FluentLabelWeightStyle GetLabelWeightStyle(BindableObject view)
        {
            return (FluentLabelWeightStyle)view.GetValue(LabelWeightStyleProperty);
        }

        public static void SetLabelWeightStyle(BindableObject view, FluentLabelWeightStyle value)
        {
            view.SetValue(LabelWeightStyleProperty, value);
        }
    }
}
