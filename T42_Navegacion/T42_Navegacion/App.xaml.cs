using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace T42_Navegacion
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new T42_Navegacion.MainPage();
            MainPage = new NavigationPage(new T42_Navegacion.MainPage())
            {
                BarBackgroundColor = Color.Blue,
                BarTextColor = Color.WhiteSmoke
            };
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
