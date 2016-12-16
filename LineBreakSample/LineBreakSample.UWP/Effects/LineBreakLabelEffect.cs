using LineBreakSample.UWP.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ResolutionGroupName("LineBreakSample")]
[assembly: ExportEffect(typeof(LineBreakLabelEffect), "LineBreakLabelEffect")]
namespace LineBreakSample.UWP.Effects
{
    public class LineBreakLabelEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var label = Control as Windows.UI.Xaml.Controls.TextBlock;

            if (label == null) { return; }

            label.TextWrapping = Windows.UI.Xaml.TextWrapping.Wrap;
            label.TextTrimming = Windows.UI.Xaml.TextTrimming.WordEllipsis;
        }

        protected override void OnDetached()
        {
        }
    }
}
