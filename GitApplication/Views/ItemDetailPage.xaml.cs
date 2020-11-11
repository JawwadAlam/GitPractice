using System.ComponentModel;
using Xamarin.Forms;
using GitApplication.ViewModels;

namespace GitApplication.Views
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