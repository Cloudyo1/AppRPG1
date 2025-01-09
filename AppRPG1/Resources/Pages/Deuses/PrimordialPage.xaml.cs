namespace AppRPG1;

public partial class PrimordialPage : ContentPage
{
	public PrimordialPage()
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
            case "Buri":
                await Navigation.PushAsync(new BuriPage());
                break;
            case "Nott":
                await Navigation.PushAsync(new NottPage());
                break;
            case "Ymir":
                await Navigation.PushAsync(new YmirPage());
                break;
            default:
                await DisplayAlert("Error", "Page not available for " + godName, "OK");
                break;
        }
    }
}