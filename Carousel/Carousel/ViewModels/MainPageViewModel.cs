using System.Windows.Input;
using Carousel.Views;
using Xamarin.Forms;

namespace Carousel.ViewModels
{
    public class MainPageViewModel
    {
        private Page _page;

        public ICommand CarouselViewCommand { get; private set; }

        public ICommand ListViewCommand { get; private set; }

        public MainPageViewModel(Page page)
        {
            _page = page;

            CarouselViewCommand = new Command(async () => await _page.Navigation.PushAsync(new CarouselViewPage()));
            ListViewCommand = new Command(async () => await _page.Navigation.PushAsync(new ListViewPage()));
        }
    }
}
