using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace AppRPG1
{
    public partial class UmbralPage : ContentPage
    {
        public UmbralPage()
        {
            InitializeComponent();
        }

        // Method to handle the confirmation button click
        private void OnConfirmButtonClicked(object sender, EventArgs e)
        {
            // Attempt to parse the values as integers
            bool isVidaMaximaValid = int.TryParse(Entry1.Text, out int vidaMaxima);
            bool isVidaAtualValid = int.TryParse(Entry2.Text, out int vidaAtual);
            bool isEscudoValid = int.TryParse(Entry3.Text, out int escudo);
            bool isDanoValid = int.TryParse(Entry4.Text, out int dano);

            // If any value is invalid, show an alert and return
            if (!isVidaMaximaValid || !isVidaAtualValid || !isEscudoValid || !isDanoValid)
            {
                DisplayAlert("Erro", "Por favor, insira valores válidos para todos os campos numéricos.", "OK");
                return;
            }

            // Collecting checkbox values
            bool envenenado = CheckBox1.IsChecked;
            bool vulneravel = CheckBox2.IsChecked;

            double danofinal = dano;
            double danototal = 0;
            double escudoinicial = escudo;
            double vidainicial = vidaAtual;

            danofinal = Math.Max(0, danofinal);

            if (vulneravel)
            {
                danofinal *= 1.25;
            }

            danototal = danofinal;

            if (escudo > 0)
            {
                int danoescudo = (int)Math.Min(danofinal, escudo);
                escudo -= danoescudo;
                danofinal -= danoescudo;
            }

            vidaAtual -= (int)Math.Floor(danofinal);

            if (envenenado)
            {
                int danoveneno = (int)(vidaMaxima * 0.05);
                vidaAtual -= danoveneno;
            }

            vidaAtual = Math.Max(0, vidaAtual);
            danofinal = Math.Floor(danofinal);
            danototal = Math.Floor(danototal);
            escudoinicial = Math.Floor(escudoinicial);
            vidainicial = Math.Floor(vidainicial);


            // Display the collected values in an alert
            DisplayAlert("Confirmado",
                $"Vida Máxima do Alvo: {vidaMaxima}\n" +
                $"Vida Inicial do Alvo: {vidainicial}\n" +
                $"Vida Atual do Alvo: {vidaAtual}\n" +
                $"Escudo Inicial do Alvo: {escudoinicial}\n" +
                $"Escudo Restante do Alvo: {escudo}\n" +
                $"Dano Causado na Vida: {danofinal}\n" +
                $"Dano Causado Total: {danototal}\n",
                "OK");
        }
    }
}