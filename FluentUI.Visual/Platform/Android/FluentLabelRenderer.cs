using Android.Content;
using FluentUI.Visual.Forms;
using FluentUI.Visual.Platform.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.FastRenderers;

[assembly: ExportRenderer(typeof(Label), typeof(FluentLabelRenderer), new[] { typeof(FluentVisual) })]
namespace FluentUI.Visual.Platform.Android
{
    public class FluentLabelRenderer : LabelRenderer
    {
        public FluentLabelRenderer(Context context) : base(context)
        {
        }
    }
}
