using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Praktika3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            AbsoluteLayout praktika = new AbsoluteLayout();

            Image image = new Image
            {
                Source = ImageSource.FromResource("Praktika3.Images.3.jpeg")
            };

            uint duration = 10 * 30 * 1000;

            Task.WhenAll
                (
                    image.ScaleTo(3 * 5, duration),
                    image.RotateXTo(15 * 20, duration),
                    image.RotateYTo(-10 * 15, duration)
                );

            praktika.Children.Add(image);
            Content = praktika;
        }

    }
}
