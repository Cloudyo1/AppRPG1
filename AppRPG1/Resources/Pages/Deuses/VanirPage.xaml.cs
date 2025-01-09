namespace AppRPG1;

public partial class VanirPage : ContentPage
{
	public VanirPage()
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
            case "Byleistr":
                await Navigation.PushAsync(new ByleistrPage());
                break;
            case "Freyja":
                await Navigation.PushAsync(new FreyjaPage());
                break;
            case "Freyr":
                await Navigation.PushAsync(new FreyrPage());
                break;
            case "Gullveig":
                await Navigation.PushAsync(new GullveigPage());
                break;
            case "Hel":
                await Navigation.PushAsync(new HelPage());
                break;
            case "Hnoss":
                await Navigation.PushAsync(new HnossPage());
                break;
            case "Kvasir":
                await Navigation.PushAsync(new KvasirPage());
                break;
            case "Lofn":
                await Navigation.PushAsync(new LofnPage());
                break;
            case "Njord":
                await Navigation.PushAsync(new NjordPage());
                break;
            case "Skadi":
                await Navigation.PushAsync(new SkadiPage());
                break;
            default:
                await DisplayAlert("Error", "Page not available for " + godName, "OK");
                break;
        }
    }
}