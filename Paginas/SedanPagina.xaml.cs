using MauiApp1.Clases;

namespace MauiApp1.Paginas;

public partial class SedanPagina : ContentPage
{
    private Sedan sedan = new Sedan();
    private bool sedanInfoVisible = false;
    
    public SedanPagina()
	{
		InitializeComponent();

        Sedan sedan = new Sedan();
        sedan.Marca = "BMW";
        sedan.Modelo = "Serie 3";
        sedan.Color = "Gris";
        sedan.Anio = 2022;
        sedan.Placa = "BMW123";
        sedan.Tipo = "Sedán";
       
        //sedan.VelocidadMaxima = "km"+200;

        string sedanInfo = $"Marca: {sedan.Marca}\nModelo: {sedan.Modelo}\nColor: {sedan.Color}\nAño: {sedan.Anio}\nPlaca: {sedan.Placa}\nTipo: {sedan.Tipo}";
        sedanLabel.Text = sedanInfo;
    }
    private void OnRegresarClicked1(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }



    private void BocinarS(object sender, EventArgs e)
    {

        if (sedanInfoVisible)
        {
            sedanInfoVisible = false;
            sedanLabel1.Text = string.Empty; // Oculta la información
        }
        else
        {
            Sedan sedan = new Sedan();

            sedan.Bocina();


            string sedanMethod = $"\nBocina: {sedan.Bocina()}";

            sedanLabel1.Text += sedanMethod;

            sedanInfoVisible = true;
        }
    }



    private void EncenderS(object sender, EventArgs e)
    {

        string sedanMethod = sedan.Encender();

        sedanLabel1.Text = sedanMethod;



    }
    private void ApagarS(object sender, EventArgs e)
    {

        string sedanMethod = sedan.Apagar();

        sedanLabel1.Text = sedanMethod;
    }
    private void AcelerarS(object sender, EventArgs e)
    {

        int nuevaVelocidad = sedan.Acelerar(sedan.FrenActual);

        if (nuevaVelocidad <= 240) // Verifica si la nueva velocidad es menor o igual a 200
        {

            string sedanMethod = $"\nAcelerando a: {nuevaVelocidad} KM/H";
            sedanLabel1.Text = sedanMethod;
        }
        else
        {
            // Aquí puedes mostrar un mensaje indicando que se ha alcanzado la velocidad máxima
            string mensaje = "Se ha alcanzado la velocidad máxima de 240 KM/H";
            sedanLabel1.Text = mensaje;
            sedan.FrenActual -= 10;
        }
    }
    private void FrenarS(object sender, EventArgs e)
    {

        int nuevaVelocidad = sedan.Frenar(sedan.FrenActual);

        if (nuevaVelocidad >= 0) // Verifica si la nueva velocidad es menor o igual a 200
        {

            string sedanMethod = $"\nAcelerando a: {nuevaVelocidad} KM/H";
            sedanLabel1.Text = sedanMethod;
        }
        else
        {
            // Aquí puedes mostrar un mensaje indicando que se ha alcanzado la velocidad máxima
            string mensaje = "No puedes frenar mas tu velocidad actual es de 0 KM/H";
            sedanLabel1.Text = mensaje;
            sedan.FrenActual += 10;
        }

    }
}
