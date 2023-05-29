
using MauiApp1.Clases;
using MauiApp1.Paginas;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
   

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        // Aquí redireccionas a otra página
        // Puedes usar el siguiente código como ejemplo:
        Navigation.PushAsync(new Carros());
    }

    private void OnCerrarClicked(object sender, EventArgs e)
    {
        // Código para finalizar la aplicación
        System.Environment.Exit(0);
    }
    
}

