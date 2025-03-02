namespace URIBased;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnSignUpClicked(object sender, EventArgs e)
    {
        bool isValid = ValidateInputs();

        if (isValid)
        {
            var userDetails = new Dictionary<string, object>
            {
                { "username", Username.Text },
                { "email", Email.Text },
                { "password", Password.Text }
            };

            await Shell.Current.GoToAsync(nameof(HomePage), userDetails);
        }
    }

    private bool ValidateInputs()
    {
        bool isValid = true;

        // Reset visibility
        UsernameError.IsVisible = false;
        EmailError.IsVisible = false;
        PasswordError.IsVisible = false;
        ConfirmPasswordError.IsVisible = false;

        if (string.IsNullOrWhiteSpace(Username.Text))
        {
            UsernameError.Text = "Username is required.";
            UsernameError.IsVisible = true;
            isValid = false;
        }

        if (string.IsNullOrWhiteSpace(Email.Text))
        {
            EmailError.Text = "Email is required.";
            EmailError.IsVisible = true;
            isValid = false;
        }

        if (string.IsNullOrWhiteSpace(Password.Text))
        {
            PasswordError.Text = "Password is required.";
            PasswordError.IsVisible = true;
            isValid = false;
        }

        if (string.IsNullOrWhiteSpace(ConfirmPassword.Text))
        {
            ConfirmPasswordError.Text = "Confirm Password is required.";
            ConfirmPasswordError.IsVisible = true;
            isValid = false;
        }
        else if (Password.Text != ConfirmPassword.Text)
        {
            ConfirmPasswordError.Text = "Passwords do not match.";
            ConfirmPasswordError.IsVisible = true;
            isValid = false;
        }

        return isValid;
    }
}
