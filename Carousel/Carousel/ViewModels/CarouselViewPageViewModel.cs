using System.Collections.ObjectModel;
using Carousel.Models;
using Xamarin.Forms;

namespace Carousel.ViewModels
{
    public class CarouselViewPageViewModel
    {
        public ObservableCollection<CarouselItemModel> Items = 
            new ObservableCollection<CarouselItemModel>
        {
            new CarouselItemModel
            {
                Title = "Красный",
                Color = Color.Red,
            },
            new CarouselItemModel
            {
                Title = "Зелёный",
                Color = Color.Green,
            },
            new CarouselItemModel
            {
                Title = "Синий",
                Color = Color.Blue,
            },
            new CarouselItemModel
            {
                Title = "Жёлтый",
                Color = Color.Yellow,
            },
            new CarouselItemModel
            {
                Title = "Оранжевый",
                Color = Color.Orange,
            },
            new CarouselItemModel
            {
                Title = "Серый",
                Color = Color.Gray,
            },
        };
    }
}
