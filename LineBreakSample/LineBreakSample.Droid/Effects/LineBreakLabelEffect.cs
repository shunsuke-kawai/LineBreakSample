using Android.Widget;
using LineBreakSample.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("LineBreakSample")]
[assembly: ExportEffect(typeof(LineBreakLabelEffect), "LineBreakLabelEffect")]
namespace LineBreakSample.Droid.Effects
{
    public class LineBreakLabelEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            Control.LayoutChange += (s, args) =>
            {
                var label = Control as TextView;

                if (label == null) { return; }

                label.Ellipsize = Android.Text.TextUtils.TruncateAt.End;
                label.SetMaxLines(2);
            };
        }

        protected override void OnDetached()
        {
        }
    }
}
