namespace Profile_Preferences_User_Page.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();

		//Gets the theme color.  Defaults to Red if no theme is set.
		string themecolor = Preferences.Get("colortheme", "Red");

		//Determine what them the user has and apply it.
		if (themecolor == "Red")
			ApplyRedTheme();
		else if (themecolor == "Blue")
			ApplyBlueTheme();
		else if (themecolor == "Green")
			ApplyGreenTheme();

		//Set the rest of the user info from Preferences.
		string firstname = Preferences.Get("firstName", "");
		string lastname = Preferences.Get("lastName", "");
		DateTime birthday = Preferences.Get("birthday", DateTime.Now);

		lblName.Text = firstname + " " + lastname;
		lblBirthday.Text = $"Birthday: {birthday.ToLongDateString()}";
	}

	//Each of the methods below apply the appropriate theme to form controls.
	private void ApplyRedTheme()
	{ 
		this.BackgroundColor = Color.FromArgb("#441111");
		layoutPageStack.BackgroundColor = Color.FromArgb("#886666");
		lblName.TextColor = Color.FromArgb("#FFBBBB");
		lblBirthday.TextColor = Color.FromArgb("#FFBBBB");
	}

	private void ApplyBlueTheme()
	{
		this.BackgroundColor = Color.FromArgb("#111144");
		layoutPageStack.BackgroundColor = Color.FromArgb("#666688");
		lblName.TextColor = Color.FromArgb("#BBBBFF");
		lblBirthday.TextColor = Color.FromArgb("#BBBBFF");
	}

	private void ApplyGreenTheme()
	{
		this.BackgroundColor = Color.FromArgb("#114411");
		layoutPageStack.BackgroundColor = Color.FromArgb("#668866");
		lblName.TextColor = Color.FromArgb("#BBFFBB");
		lblBirthday.TextColor = Color.FromArgb("#BBFFBB");
	}
}