using MauiApp1.Clases;
namespace MauiApp1.Paginas;


using Microsoft.Maui.Controls;
using System;

public partial class SUVPagina : ContentPage
{
    private SUV suv = new SUV();
    private bool suvInfoVisible = false;
    

    public SUVPagina()
	{
		InitializeComponent();
        SUV suv = new SUV();
        suv.Marca = "Isuzu";
        suv.Modelo = "Mux";
        suv.Color = "Negro";
        suv.Anio = 2023;
        suv.Placa = "Mux123";
        suv.Tipo = "SUV";
        

        string suvInfo = $"Marca: {suv.Marca}\nModelo: {suv.Modelo}\nColor: {suv.Color}\nAño: {suv.Anio}\nPlaca: {suv.Placa}\nTipo: {suv.Tipo}";
        suvLabel.Text = suvInfo;

    }

    private void OnRegresarClicked1(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void BocinarV(object sender, EventArgs e)
    {

        if (suvInfoVisible)
        {
            suvInfoVisible = false;
            suvLabel1.Text = string.Empty; // Oculta la información
        }
        else
        {
            SUV suv = new SUV();

            suv.Bocina();


            string suvMethod = $"\nBocina: {suv.Bocina()}";

            suvLabel1.Text += suvMethod;

            suvInfoVisible = true;
        }
    }



    private void EncenderV(object sender, EventArgs e)
    {

        string suvMethod = suv.Encender();

        suvLabel1.Text = suvMethod;



    }
    private void ApagarV(object sender, EventArgs e)
    {

        string suvMethod = suv.Apagar();

        suvLabel1.Text = suvMethod;
    }
    private void AcelerarV(object sender, EventArgs e)
    {

        int nuevaVelocidad = suv.Acelerar(suv.FrenActual);

        if (nuevaVelocidad <= 200) // Verifica si la nueva velocidad es menor o igual a 200
        {
            
            string suvMethod = $"\nAcelerando a: {nuevaVelocidad} KM/H";
            suvLabel1.Text = suvMethod;
        }
        else
        {
            // Aquí puedes mostrar un mensaje indicando que se ha alcanzado la velocidad máxima
            string mensaje = "Se ha alcanzado la velocidad máxima de 200 KM/H";
            suvLabel1.Text = mensaje;
            suv.FrenActual -= 10;
        }
    }
    private void FrenarV(object sender, EventArgs e)
    {

        int nuevaVelocidad = suv.Frenar(suv.FrenActual);

        if (nuevaVelocidad >= 0) // Verifica si la nueva velocidad es menor o igual a 200
        {

            string suvMethod = $"\nAcelerando a: {nuevaVelocidad} KM/H";
            suvLabel1.Text = suvMethod;
        }
        else
        {
            // Aquí puedes mostrar un mensaje indicando que se ha alcanzado la velocidad máxima
            string mensaje = "No puedes frenar mas tu velocidad actual es de 0 KM/H";
            suvLabel1.Text = mensaje;
            suv.FrenActual += 10;
        }

    }
}
