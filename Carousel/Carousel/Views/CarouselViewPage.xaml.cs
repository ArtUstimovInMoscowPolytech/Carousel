using Carousel.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Carousel.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewPage : ContentPage
    {
        private CarouselViewPageViewModel _viewModel;
        public CarouselViewPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new CarouselViewPageViewModel();
            carousel.ItemsSource = _viewModel.Items;
        }
    }
}
