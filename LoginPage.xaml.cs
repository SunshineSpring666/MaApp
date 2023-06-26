namespace MaApp;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void LogInAndRemoveLoginPageFromStackClicked(object sender, EventArgs e)
    {
        // Generally LoginPage needs to be removed after logging in, in order to stop user from popping to it.
        // TO-DO: the following code ends up crashing. Are there any ways to solve it?
        Navigation.InsertPageBefore(new MainPage(), this);
        await Navigation.PopToRootAsync();  
    }

    private async void LogInByPushingAnotherPageOntoStackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}