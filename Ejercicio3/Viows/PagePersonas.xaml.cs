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
    public partial class PagePersonas : ContentPage
    {
        public PagePersonas()
        {
            InitializeComponent();
        }
        private  async void bntsalvar_cliked(object sender, EventArgs e)
       
        {
            var perso = new Models.Personas()
            
            {
                nombres = txtnombres.Text,
                apellidos = txtapellidos.Text,
                edad = txtedad.Text,
                correo = txtcorreo.Text,
                direccion = txtdireccion.Text,

            };
            if (await App.DBPerso.SavePerso(perso) > 0)
                await DisplayAlert("Aviso", "Persona Ingresada", "OK");
            else
                await DisplayAlert("Aviso", "Error", "OK");

            var page = new Viows.PageResultado();
            page.BindingContext = perso;
            await Navigation.PushAsync(page);

        }
    }
}