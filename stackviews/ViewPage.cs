using Xamarin.Forms;

namespace stackviews
{
    public class ViewPage : ContentPage
    {
        public ViewPage()
        {
            AbsoluteLayout stack = null;

            var image = new Image
            {
                Source = "corrosive.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            var tapImage = new TapGestureRecognizer
            {
                NumberOfTapsRequired = 1,
                Command = new Command((t) =>
                    {
                        var view = new ViewInfo();
                        var layout = new AbsoluteLayout()
                        {
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            HorizontalOptions = LayoutOptions.CenterAndExpand,
                            Children = { view }
                        };
                        stack.Children.Add(layout);
                    })
            };
            image.GestureRecognizers.Add(tapImage);

            stack = new AbsoluteLayout
            { 
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children =
                {
                    image
                }
            };

            Content = stack;
        }
    }
}


