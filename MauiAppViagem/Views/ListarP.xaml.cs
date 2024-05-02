using System.Collections.ObjectModel;
using MauiAppViagem.Models;

namespace MauiAppViagem.Views;

public partial class ListarP : ContentPage
{
	ObservableCollection<pedagio> lista_pedagios = new ObservableCollection<pedagio>();
	public ListarP()
	{
		InitializeComponent();

		lst_pedagios.ItemsSource = lista_pedagios;
	}

	protected async override void OnAppearing()
	{
		if (lista_pedagios.Count == 0)
		{
			List<pedagio> tmp = await App.Db.GetAll();
            foreach (pedagio p in tmp)
            {
                lista_pedagios.Add(p);
            }
        }
	}
}