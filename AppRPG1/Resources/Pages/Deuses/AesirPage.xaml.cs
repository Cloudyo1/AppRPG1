namespace AppRPG1;

public partial class AesirPage : ContentPage
{
	public AesirPage()
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
            case "Aegir":
                await Navigation.PushAsync(new AegirPage());
                break;
            case "Balder":
                await Navigation.PushAsync(new BalderPage());
                break;
            case "Bragi":
                await Navigation.PushAsync(new BragiPage());
                break;
            case "Forseti":
                await Navigation.PushAsync(new ForsetiPage());
                break;
            case "Frigg":
                await Navigation.PushAsync(new FriggPage());
                break;
            case "Heimdall":
                await Navigation.PushAsync(new HeimdallPage());
                break;
            case "Hodr":
                await Navigation.PushAsync(new HodrPage());
                break;
            case "Hoenir":
                await Navigation.PushAsync(new HoenirPage());
                break;
            case "Idunn":
                await Navigation.PushAsync(new IdunnPage());
                break;
            case "Loki":
                await Navigation.PushAsync(new LokiPage());
                break;
            case "Mani":
                await Navigation.PushAsync(new ManiPage());
                break;
            case "Odin":
                await Navigation.PushAsync(new OdinPage());
                break;
            case "Ran":
                await Navigation.PushAsync(new RanPage());
                break;
            case "Sif":
                await Navigation.PushAsync(new SifPage());
                break;
            case "Sigyn":
                await Navigation.PushAsync(new SigynPage());
                break;
            case "Sunna":
                await Navigation.PushAsync(new SunnaPage());
                break;
            case "Thor":
                await Navigation.PushAsync(new ThorPage());
                break;
            case "Tyr":
                await Navigation.PushAsync(new TyrPage());
                break;
            case "Ullr":
                await Navigation.PushAsync(new UllrPage());
                break;
            case "Vali":
                await Navigation.PushAsync(new ValiPage());
                break;
            case "Vidarr":
                await Navigation.PushAsync(new VidarrPage());
                break;
            case "Vili":
                await Navigation.PushAsync(new ViliPage());
                break;
            default:
                await DisplayAlert("Error", "Page not available for " + godName, "OK");
                break;
        }
    }
}