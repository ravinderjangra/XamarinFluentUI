using Xamarin.Forms;

namespace FluentUI.Visual.Forms
{
    public static class FluentButton
    {
        public static readonly BindableProperty ButtonStyleProperty =
            BindableProperty.CreateAttached(
                "ButtonStyle",
                typeof(FluentButtonStyle),
                typeof(Button),
                FluentButtonStyle.PrimaryFilled);

        public static FluentButtonStyle GetButtonStyle(BindableObject view)
        {
            return (FluentButtonStyle)view.GetValue(ButtonStyleProperty);
        }

        public static void SetButtonStyle(BindableObject view, FluentButtonStyle value)
        {
            view.SetValue(ButtonStyleProperty, value);
        }
    }
}
