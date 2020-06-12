using System.ComponentModel;
using Android.Content;
using FluentUI.Visual.Forms;
using FluentUI.Visual.Platform.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using FluentButton = FluentUI.Button;

[assembly: ExportRenderer(typeof(Button), typeof(FluentButtonRenderer), new[] { typeof(FluentVisual) })]

namespace FluentUI.Visual.Platform.Android
{
    public class FluentButtonRenderer : ButtonRenderer
    {
        public FluentButtonRenderer(Context context) : base (context)
        {
        }

        protected override global::Android.Widget.Button CreateNativeControl()
        {
            var fluentBtn = new FluentButton(Context);
            return fluentBtn;
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            //if (e.PropertyName == FluentButton.ButtonStyleProperty.PropertyName)
            //    UpdateButtonStyle();
        }

        private void UpdateButtonStyle()
        {
            //if (Control != null)
            //{
            //    var style = FluentButton.GetButtonStyle(Element);
            //}
        }
    }
}
