using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace AppRPG1
{
    public partial class ImpactPage : ContentPage
    {
        public ImpactPage()
        {
            InitializeComponent();
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            // Update the label with the slider value
            SliderValueLabel.Text = $"Valor: {e.NewValue:F0}";
        }

        // Method to handle the confirmation button click
        private void OnConfirmButtonClicked(object sender, EventArgs e)
        {
            // Attempt to parse the values as integers
            bool isVidaMaximaValid = int.TryParse(Entry1.Text, out int vidaMaxima);
            bool isVidaAtualValid = int.TryParse(Entry2.Text, out int vidaAtual);
            bool isEscudoValid = int.TryParse(Entry3.Text, out int escudo);
            bool isDurabilidadeValid = int.TryParse(Entry4.Text, out int durabilidade);
            bool isArmaduraValid = int.TryParse(Entry5.Text, out int armadura);
            bool isDanoValid = int.TryParse(Entry6.Text, out int dano);

            // If any value is invalid, show an alert and return
            if (!isVidaMaximaValid || !isVidaAtualValid || !isEscudoValid || !isDurabilidadeValid ||
                !isArmaduraValid || !isDanoValid)
            {
                DisplayAlert("Erro", "Por favor, insira valores válidos para todos os campos numéricos.", "OK");
                return;
            }

            Random random = new Random();
            bool atordoamento = random.NextDouble() <= 0.125;

            // Collecting the slider value
            double penetracao = ValueSlider.Value;

            // Collecting checkbox values
            bool envenenado = CheckBox1.IsChecked;
            bool vulneravel = CheckBox2.IsChecked;

            double danofinal = dano;
            double danototal = 0;
            double escudoinicial = escudo;
            double vidainicial = vidaAtual;

            double armadurareduzida = armadura * (1 - penetracao / 100.0);
            double armorreduction = Math.Min(armadurareduzida / 10 * 0.01, 0.75);

            danofinal *= (1 - armorreduction);
            danofinal -= durabilidade;
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
                $"Dano Causado Total: {danototal}\n" +
                $"Atordoamento: {atordoamento}\n",
                "OK");
        }
    }
}