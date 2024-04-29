using Microsoft.Maui.Controls.Compatibility.Platform.UWP;
using System.Collections.ObjectModel;
using MauiAppViagem.Models;

namespace MauiAppViagem.Views;

public partial class ListarP : ContentPage
{
	ObservableCollection<Pedagio> lista_pedagios = new ObservableCollection<Pedagio>();
	public ListarP()
	{
		InitializeComponent();

		lst_pedagios.ItemSource = lista_pedagios;
	}

	protected async override void OnAppearing()
	{
		if (lista_pedagios.Count == 0)
		{
			List<Pedagio> tmp = await App.Db.GetAll();
            foreach (Pedagio p in tmp)
            {
                lista_pedagios.Add(p);
            }
        }
	}
}