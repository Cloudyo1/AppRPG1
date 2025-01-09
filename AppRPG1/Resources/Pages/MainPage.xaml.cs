using Microsoft.Maui.Controls;

namespace AppRPG1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
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
                if (frame == Button1)
                {
                    await Navigation.PushAsync(new DamagePage());
                }
                else if (frame == Button2)
                {
                    await Navigation.PushAsync(new CreaturesPage());
                }
                else if (frame == Button3)
                {
                    await Navigation.PushAsync(new GodsPage());
                }
            }
        }
    }
}