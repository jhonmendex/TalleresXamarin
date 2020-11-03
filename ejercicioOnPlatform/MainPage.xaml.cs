using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ejercicioOnPlatform
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Grid(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EjercicioGrid());
        }
        async void Button_OnPlat(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EjercicioOnPlat());
        }
        async void Button_ExtMar(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EjercicioExtensiones());
        }

        async void static_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new StaticRef());
        }

       async void Binding_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MyBindings());
        }

        async void Colections_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Convertions());
        }

        async void triggers_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Triggers());
        }

        async void behaviors_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Behaviors());
        }
    }
}
