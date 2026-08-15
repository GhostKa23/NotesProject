namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage() //metodo construtor
        {
            InitializeComponent();
        }
        /*
        private void OnCounterClicked(object? sender, EventArgs e) //metodo = bloco de codigo que faz uma ação
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }*/

        private void AoClicarSalvar(object? sender, EventArgs e)
        {
            
        }

        private void AoClicarApagar(object? sender, EventArgs e)
        {

        }

        private void AoClicarCarregar(object? sender, EventArgs e)
        {

        }

    }       
}           
            
            
            
 // modificadores de acesso privado e publico || void = metodo sem retorno
