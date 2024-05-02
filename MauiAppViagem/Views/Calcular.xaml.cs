using MauiAppViagem.Models;

namespace MauiAppViagem.Views;

public partial class Calcular : ContentPage
{

    double total = 0;
    double valor_total = 0;

	public Calcular()
	{
		InitializeComponent();

        //lbl_local.Text = "Origem: " + MainPage.via.Origem;
        //lbl_destino.Text = "Destino: " + MainPage.via.Destino;
        lbl_valor.IsVisible = false;

	}

    private async void btn_somar_Clicked(object sender, EventArgs e)
    {
        List<pedagio> pedagios = await App.Db.GetAll();

        foreach (var item in pedagios)
        {
            valor_total += valor_total;
        }

      
        await DisplayAlert("Soma total: ", $"Pedagio: {valor_total.ToString("C")}\nConsumo: \n--------\nTotal: {total.ToString("C")}", "Ok");
        lbl_valor.Text = "Valor: " + total.ToString();
        lbl_valor.IsVisible = true;
    }

    private void btn_novaviagem_Clicked(object sender, EventArgs e)
    {

    }
}