namespace URIBased;
[QueryProperty(nameof(User_Name), "username")]
[QueryProperty(nameof(Email), "email")]
public partial class HomePage : ContentPage
{
	public string User_Name { get; set; }
	public string Email { get; set; }
    public HomePage()
	{
		InitializeComponent();
        BindingContext = this;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LblUsername.Text = $"Username: {User_Name}";
        LblEmail.Text = $"Email: {Email}";

        ConfirmationMessage.Text = "Signup successful! Welcome to your profile.";
    }

    private async void OnSignOutClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}