namespace AppRPG1;

public partial class CreaturesPage : ContentPage
{
    public CreaturesPage()
    {
        InitializeComponent();
    }

    private async void OnCreatureButtonClicked(object sender, EventArgs e)
    {
        // Handle button clicks here
        Button button = sender as Button;
        string creatureName = button.Text;

        switch (creatureName)
        {
            case "Dokkalfar":
                await Navigation.PushAsync(new DokkalfarPage());
                break;
            case "Draugr":
                await Navigation.PushAsync(new DraugrPage());
                break;
            case "Dvergar":
                await Navigation.PushAsync(new DvergarPage());
                break;
            case "Fenrir":
                await Navigation.PushAsync(new FenrirPage());
                break;
            case "Goblin":
                await Navigation.PushAsync(new GoblinPage());
                break;
            case "Hart":
                await Navigation.PushAsync(new HartPage());
                break;
            case "Hulder":
                await Navigation.PushAsync(new HulderPage());
                break;
            case "Jormungandr":
                await Navigation.PushAsync(new JormungandrPage());
                break;
            case "Jotun":
                await Navigation.PushAsync(new JotunPage());
                break;
            case "Lindwyrm":
                await Navigation.PushAsync(new LindwyrmPage());
                break;
            case "Ljosalfar":
                await Navigation.PushAsync(new LjosalfarPage());
                break;
            case "Mimir":
                await Navigation.PushAsync(new MimirPage());
                break;
            case "Nidhoggr":
                await Navigation.PushAsync(new NidhoggrPage());
                break;
            case "Niflungr":
                await Navigation.PushAsync(new NiflungrPage());
                break;
            case "Norns":
                await Navigation.PushAsync(new NornsPage());
                break;
            case "Nuckelavee":
                await Navigation.PushAsync(new NuckelaveePage());
                break;
            case "Ratatoskr":
                await Navigation.PushAsync(new RatatoskrPage());
                break;
            case "Skrymir":
                await Navigation.PushAsync(new SkrymirPage());
                break;
            case "Stags":
                await Navigation.PushAsync(new StagsPage());
                break;
            case "Surtur":
                await Navigation.PushAsync(new SurturPage());
                break;
            case "Swans":
                await Navigation.PushAsync(new SwansPage());
                break;
            case "Troll":
                await Navigation.PushAsync(new TrollPage());
                break;
            case "Valravn":
                await Navigation.PushAsync(new ValravnPage());
                break;
            case "Vedrfolnir":
                await Navigation.PushAsync(new VedrfolnirPage());
                break;
            case "Wolves":
                await Navigation.PushAsync(new WolvesPage());
                break;
            default:
                await DisplayAlert("Error", "Page not available for " + creatureName, "OK");
                break;
        }
    }
}