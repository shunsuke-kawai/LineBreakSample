
using Xamarin.Forms;

namespace LineBreakSample
{
    public class SamplePage : ContentPage
    {
        public SamplePage()
        {
            AbsoluteLayout layout = new AbsoluteLayout
            {
                HeightRequest = 25
            };

            Label label = new Label
            {
                Text = "テキストテキストテキストテキストテキストテキストテキストテキストテキストテキストテキストテキストテキストテキストテキストテキストテキストテキスト",
                FontSize = 12,
                VerticalTextAlignment = TextAlignment.Center,
            };
            label.Effects.Add(Effect.Resolve("LineBreakSample.LineBreakLabelEffect"));

            AbsoluteLayout.SetLayoutFlags(label, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(label, new Rectangle(0.5, 0.5, 0.5, 1));
            layout.Children.Add(label);

            Content = layout;
        }
    }
}
