using Carousel.ViewModels;
using Xamarin.Forms;

namespace Carousel.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(this);
        }
    }
}
