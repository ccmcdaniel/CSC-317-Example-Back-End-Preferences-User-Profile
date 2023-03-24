using System.Collections.ObjectModel;

namespace Profile_Preferences_User_Page;

public partial class App : Application
{
	public static ObservableCollection<string> listOfDrawingColours 
		= new ObservableCollection<string> { "Red", "Green", "Blue" };

	public App()
	{
		InitializeComponent();

		//Before we load the main page, check to see if there has already been
		//a profile created.
		//If yes, then skip directly to the home page(loaded by AppShell)
		//If no, then show the Profile Setup Page first.  
		if (Preferences.ContainsKey("hasprofile") == true)
			MainPage = new AppShell();
		else
			MainPage = new Pages.ProfileSetupPage();
	}
}
