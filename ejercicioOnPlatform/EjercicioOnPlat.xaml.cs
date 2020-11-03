using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ejercicioOnPlatform
{
    public partial class EjercicioOnPlat : ContentPage
    {
        public EjercicioOnPlat()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.iOS)
            {
                Padding = new Thickness(50);
            }

        }
    }
}
