using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace ShoppingApp.Views
{

	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}
		private void OnLoginClicked(object sender, EventArgs e)
		{
			string name = NameEntry.Text.Trim();
			string email = EmailEntry.Text.Trim();

			if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
			{
				DisplayAlert("Error", "Please fill in all fields.", "OK");
				return;
			}
			//Navigation.PushAsync( new ProfilePage (name, email));
		}

	}
}