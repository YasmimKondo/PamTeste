namespace programa
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Escolha_Clicked(object sender, EventArgs e)
        {

            int numeroSorteado = new Random().Next(2);
            string selecionar = PickerDuplo.SelectedItem.ToString();
            if (numeroSorteado == 0)
            {
                ImagemDado.Source = "cara.png";
            }
            if (numeroSorteado == 1)
            {
                ImagemDado.Source = "coroa.png";
            }
            if (numeroSorteado == 0 && selecionar == "Cara")
            {
                NomeResul.Text = "Parabéns deu cara!";
            }
            if (numeroSorteado == 0 && selecionar == "Coroa")
            {
                NomeResul.Text = "Que pena deu cara!";
            }
            if (numeroSorteado == 1 && selecionar == "Coroa")
            {
                NomeResul.Text = "Parabéns deu coroa!";
            }
            if(numeroSorteado == 1 && selecionar == "Cara")
            {
                NomeResul.Text = "Que pena deu caroa!";
            }
        }
    }

}
