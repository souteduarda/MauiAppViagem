using MauiAppViagem.Models;

namespace MauiAppViagem
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        private async void btn_AddPedagio_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Pedagio());
        }

        private async void btn_Calcular_Clicked(object sender, EventArgs e)
        {
            viagem via = new viagem();
            via.Origem = txt_origem.Text;
            via.Destino = txt_destino.Text;
            via.Distancia = Convert.ToDouble(txt_distancia.Text);
            via.Rendimento = Convert.ToDouble(txt_rendimento.Text);
            via.Preco = Convert.ToDouble(txt_gasolina.Text);

            await Navigation.PushAsync(new Views.Calcular());
        }

        private async void btn_ListaPedagio_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.ListarP());
        }
    }

}
