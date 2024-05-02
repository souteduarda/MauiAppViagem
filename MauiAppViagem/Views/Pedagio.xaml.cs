using MauiAppViagem.Models;
namespace MauiAppViagem.Views;

public partial class Pedagio : ContentPage
{
    public Pedagio()
    {
        InitializeComponent();
    }

    private async void btn_add_Clicked(object sender, EventArgs e)
    {
        try
        {
            pedagio p = new pedagio();
            p.Local = txt_local.Text;
            p.Valor = Convert.ToDouble(txt_valor.Text);

            await App.Db.Insert(p);
            await DisplayAlert("Sucesso!", "O pedágio foi adicionado", "OK");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", ex.Message, "OK");
        }
    }
}
