using Xamarin.Forms;

namespace FluentUI.Visual.Forms
{
    public static class FluentActivityIndicator
    {
        public static readonly BindableProperty ActivityIndicatorStyleProperty =
            BindableProperty.CreateAttached(
                "ActivityIndicatorStyle",
                typeof(FluentSpinnerStyle),
                typeof(FluentActivityIndicator),
                FluentSpinnerStyle.Medium);

        public static FluentSpinnerStyle GetActivityIndicatorStyle(BindableObject view)
        {
            return (FluentSpinnerStyle)view.GetValue(ActivityIndicatorStyleProperty);
        }

        public static void SetActivityIndicatorStyle(BindableObject view, FluentSpinnerStyle value)
        {
            view.SetValue(ActivityIndicatorStyleProperty, value);
        }
    }
}
