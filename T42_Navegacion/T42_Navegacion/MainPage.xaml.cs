using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace T42_Navegacion
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            //InitializeComponent();
            Title = "Página principal";
            Button irANoModal = new Button
            {
                Text = "Ir a la página No Modal",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            irANoModal.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new PaginaNoModal());
            };
            Button irAModal = new Button
            {
                Text = "Ir a la página Modal",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            irAModal.Clicked += async (sender, args) =>
            {
                await Navigation.PushModalAsync(new PaginaModal());
            };
            Content = new StackLayout
            {
                Children =
                {
                    irANoModal,
                    irAModal
                }
            };
		}
	}
}
