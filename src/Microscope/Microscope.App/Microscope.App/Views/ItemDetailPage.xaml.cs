using Microscope.App.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Microscope.App.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}