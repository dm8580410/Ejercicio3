using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace Ejercicio3
{
    public partial class App : Application
    {
         static Controller.PersonaController dbPerso;

        public static Controller.PersonaController DBPerso
        {
            get
            { 
                if (dbPerso == null)
                {
                    var dpath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    var dbname = "perso.db3";
                    dbPerso = new Controller.PersonaController(Path.Combine(dpath, dbname));

                }
                return dbPerso;

            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Viows.PageInicial());
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
