using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace T42_Navegacion
{
	public class PaginaNoModal : ContentPage
	{
		public PaginaNoModal ()
		{
            Title = "Página No Modal";
            Button atras = new Button
            {
                Text = "Volver a la página principal",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            atras.Clicked += async (sender, args) =>
            {
                await Navigation.PopAsync();
            };
            Content = atras;
		}
	}
}