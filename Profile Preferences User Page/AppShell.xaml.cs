namespace Profile_Preferences_User_Page;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

	private void ExitProgram(object sender, EventArgs e)
	{
		Application.Current.Quit();
	}
	
	//Show the Profile Setup Page if the user wishes to change the profile.
	private void NewUserProfile(object sender, EventArgs e)
	{
		Application.Current.MainPage = new Pages.ProfileSetupPage();
	}
}
