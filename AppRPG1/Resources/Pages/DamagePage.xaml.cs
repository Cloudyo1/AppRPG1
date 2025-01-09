namespace AppRPG1;

public partial class DamagePage : ContentPage
{
	public DamagePage()
	{
		InitializeComponent();
	}
    // Method to handle the button click
    private async void OnButtonClicked(object sender, EventArgs e)
    {
        if (sender is Frame frame)
        {
            // Change to the pressed color
            frame.BackgroundColor = Color.FromArgb("#36040a");

            // Wait for a short period
            await Task.Delay(100);
            frame.BackgroundColor = Color.FromArgb("#4d0912");

            // Navigate based on button name
            if (frame == slash)
            {
                await Navigation.PushAsync(new SlashPage());
            }
            else if (frame == puncture)
            {
                await Navigation.PushAsync(new PuncturePage());
            }
            else if (frame == impact)
            {
                await Navigation.PushAsync(new ImpactPage());
            }
            else if (frame == heat)
            {
                await Navigation.PushAsync(new FirePage());
            }
            else if (frame == cold)
            {
                await Navigation.PushAsync(new ColdPage());
            }
            else if (frame == toxin)
            {
                await Navigation.PushAsync(new ToxinPage());
            }
            else if (frame == electric)
            {
                await Navigation.PushAsync(new ElectricPage());
            }
            else if (frame == umbral)
            {
                await Navigation.PushAsync(new UmbralPage());
            }
        }
    }
}