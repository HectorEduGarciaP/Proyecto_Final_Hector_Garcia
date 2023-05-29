namespace MauiApp1.Paginas;

using MauiApp1.Clases;
using Microsoft.Maui.Controls;
public partial class Carros : ContentPage
{
    
   

    public Carros()
    {
        InitializeComponent();
    }
    private void OnRegresarClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SedanPagina());
    }

    private void OnCounterClicked1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PickUpPagina());
    }
    private void OnCounterClicked2(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SUVPagina());
    }

    private void OnCounterClicked3(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CuatroPagina());
    }
    private void OnCounterClicked8(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NuevoPagina());
    }


}