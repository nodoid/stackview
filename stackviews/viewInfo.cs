using Xamarin.Forms;

namespace stackviews
{
    public class ViewInfo : ContentView
    {
        public ViewInfo()
        {
            Content = new StackLayout
            {
                WidthRequest = 300,
                HeightRequest = 300,
                Opacity = .75,
                BackgroundColor = Color.Silver,
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Padding = new Thickness(12, 12),
                Children =
                {
                    new Label
                    {
                        Text = "Hello John",
                        TextColor = Color.Red
                    },
                    new Label
                    {
                        Text = "Got a new motor?",
                        TextColor = Color.Blue,
                    },
                    new Button
                    {
                        Text = "Close",
                        Command = new Command((t) =>
                            {
                                Content = null; // "removes" the view
                            })
                    }
                }
            };
        }
    }
}


