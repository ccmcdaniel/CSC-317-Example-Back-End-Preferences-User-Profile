using System.Collections.ObjectModel;
using System.Reflection;

namespace Profile_Preferences_User_Page.Pages;

public partial class ProfileSetupPage : ContentPage
{
	bool setBirthday = false;
	public ProfileSetupPage()
	{
		InitializeComponent();
	}

	private async void FinishProfile(object sender, EventArgs e)
	{
		//Check to ensure that the form was filled out entirely before proceeding.
		if (	txtFirstName.Text == "" ||
				txtLastName.Text == "" ||
				setBirthday == false ||
				!(rdoRed.IsChecked == true 
					|| rdoGreen.IsChecked == true 
					||  rdoBlue.IsChecked == true)
		   )
		{
			//if something wasn't filled out, then display an alert.
			await DisplayAlert("Error", "One or more fields was not selected.", "Ok");
		}
		else
		{
			//Otherwise, update the user preferences with the user's new settings.
			Preferences.Set("hasprofile", true);
			Preferences.Set("firstName", txtFirstName.Text);
			Preferences.Set("lastName", txtLastName.Text);
			Preferences.Set("birthday", dteBirthday.Date);

			if(rdoRed.IsChecked == true)
				Preferences.Set("colortheme", "Red");

			else if (rdoGreen.IsChecked == true)
				Preferences.Set("colortheme", "Green");

			else if (rdoBlue.IsChecked == true)
				Preferences.Set("colortheme", "Blue");

			//Changes the base page of the application to be the App Shell, which
			//houses the Home Page (Check out AppShell.xaml)
			App.Current.MainPage = new AppShell();
		}
	}

	//This is used to mark whether the user changed the birth date box.  
	private void MarkBirthday(object sender, DateChangedEventArgs e)
	{
		setBirthday = true;
	}


}