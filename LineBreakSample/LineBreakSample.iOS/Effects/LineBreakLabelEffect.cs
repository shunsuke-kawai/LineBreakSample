using LineBreakSample.iOS.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("LineBreakSample")]
[assembly: ExportEffect(typeof(LineBreakLabelEffect), "LineBreakLabelEffect")]
namespace LineBreakSample.iOS.Effects
{
    public class LineBreakLabelEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var label = Control as UILabel;

            if (label == null) { return; }
            label.LineBreakMode = UILineBreakMode.TailTruncation;
            label.Lines = 2;
        }

        protected override void OnDetached()
        {
        }
    }
}
