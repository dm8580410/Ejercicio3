using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio3.Viows
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageInicial : ContentPage
    {
        public PageInicial()
        {
            InitializeComponent();
        }
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var pagePersonas = new Viows.PagePersonas();
            Navigation.PushAsync(pagePersonas);
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {

        }

        private void listaperso_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listaperso.ItemsSource = await App.DBPerso.GetListpers();

        }
    }
}