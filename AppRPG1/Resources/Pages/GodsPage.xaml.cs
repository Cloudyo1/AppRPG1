namespace AppRPG1;

public partial class GodsPage : ContentPage
{
	public GodsPage()
	{
		InitializeComponent();
	}

    private async void OnCreatureButtonClicked(object sender, EventArgs e)
    {
        // Handle button clicks here
        Button button = sender as Button;
        string godName = button.Text;

        switch (godName)
        {
            case "Aesir":
                await Navigation.PushAsync(new AesirPage());
                break;
            case "Primordial":
                await Navigation.PushAsync(new PrimordialPage());
                break;
            case "Vanir":
                await Navigation.PushAsync(new VanirPage());
                break;
            default:
                await DisplayAlert("Error", "Page not available for " + godName, "OK");
                break;
        }
    }
}