using MauiApp1.Clases;

namespace MauiApp1.Paginas;

public partial class PickUpPagina : ContentPage
{

    private PickUp pickUp = new PickUp();
    private bool pickUpInfoVisible = false;
    public PickUpPagina()
	{
		InitializeComponent();
       
        pickUp.Marca = "Izusu";
        pickUp.Modelo = "Dmax";
        pickUp.Color = "Blanco";
        pickUp.Anio = 2023;
        pickUp.Placa = "ABC123";
        pickUp.Tipo = "PickUp";
        

        string pickUpInfo = $"Marca: {pickUp.Marca}\nModelo: {pickUp.Modelo}\nColor: {pickUp.Color}\nAño: {pickUp.Anio}\nPlaca: {pickUp.Placa}\nTipo: {pickUp.Tipo}";
        pickUpLabel.Text = pickUpInfo;
    }
    private void OnRegresarClicked1(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void BocinarP(object sender, EventArgs e)
    {

        if (pickUpInfoVisible)
        {
            pickUpInfoVisible = false;
            pickUpLabel1.Text = string.Empty; // Oculta la información
        }
        else
        {
            

            pickUp.Bocina();


            string pickUpMethod = $"\nBocina: {pickUp.Bocina()}";

            pickUpLabel1.Text += pickUpMethod;

            pickUpInfoVisible = true;
        }
    }



    private void EncenderP(object sender, EventArgs e)
    {

        string pickUpMethod = pickUp.Encender();

        pickUpLabel1.Text = pickUpMethod;



    }
    private void ApagarP(object sender, EventArgs e)
    {

        string pickUpMethod = pickUp.Apagar();

        pickUpLabel1.Text = pickUpMethod;
    }
    private void AcelerarP(object sender, EventArgs e)
    {

        int nuevaVelocidad = pickUp.Acelerar(pickUp.FrenActual);

        if (nuevaVelocidad <= 180) // Verifica si la nueva velocidad es menor o igual a 200
        {

            string pickUpMethod = $"\nAcelerando a: {nuevaVelocidad} KM/H";
            pickUpLabel1.Text = pickUpMethod;
        }
        else
        {
            // Aquí puedes mostrar un mensaje indicando que se ha alcanzado la velocidad máxima
            string mensaje = "Se ha alcanzado la velocidad máxima de 180 KM/H";
            pickUpLabel1.Text = mensaje;
            pickUp.FrenActual -= 10;
        }
    }
    private void FrenarP(object sender, EventArgs e)
    {

        int nuevaVelocidad = pickUp.Frenar(pickUp.FrenActual);

        if (nuevaVelocidad >= 0) // Verifica si la nueva velocidad es menor o igual a 200
        {

            string pickUpMethod = $"\nAcelerando a: {nuevaVelocidad} KM/H";
            pickUpLabel1.Text = pickUpMethod;
        }
        else
        {
            // Aquí puedes mostrar un mensaje indicando que se ha alcanzado la velocidad máxima
            string mensaje = "No puedes frenar mas tu velocidad actual es de 0 KM/H";
            pickUpLabel1.Text = mensaje;
            pickUp.FrenActual += 10;
        }

    }
}