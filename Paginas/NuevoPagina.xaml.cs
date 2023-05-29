
using MauiApp1.Clases;

namespace MauiApp1.Paginas;

public partial class NuevoPagina : ContentPage
{
    private Nuevo nuevo = new Nuevo();
    private bool nuevoInfoVisible = false;
    public NuevoPagina()
    {
        InitializeComponent();
        nuevo.Marca = "";
        nuevo.Modelo = "";
        nuevo.Color = "";
        nuevo.Anio = 0;
        nuevo.Placa = "";
        nuevo.Tipo = "";
        nuevo.VelocidadMaxima = 0;
        ActualizarNuevoInfo();
    }

    private void ActualizarNuevoInfo()
    {
        string NuevoInfo = $"Marca: {nuevo.Marca}\nModelo: {nuevo.Modelo}\nColor: {nuevo.Color}\nAño: {nuevo.Anio}\nPlaca: {nuevo.Placa}\nTipo: {nuevo.Tipo}\nVelocidad Maxima: {nuevo.VelocidadMaxima}";
        nuevoLabel.Text = NuevoInfo;
    }
    private void Nuevocarro(object sender, EventArgs e)
    {
        nuevo.Marca = marcaEntry.Text;
        nuevo.Modelo = modeloEntry.Text;
        nuevo.Color = colorEntry.Text;
        if (int.TryParse(anioEntry.Text, out int anio))
        {
            nuevo.Anio = anio;
        }
        nuevo.Placa = placaEntry.Text;
        nuevo.Tipo = tipoEntry.Text;
        if (int.TryParse(maximaEntry.Text, out int velocidadMaxima))
        {
            nuevo.VelocidadMaxima = velocidadMaxima;
        }
        ActualizarNuevoInfo();
    }
    private void OnRegresarClicked5(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
    private void BocinarN(object sender, EventArgs e)
    {
        if (nuevoInfoVisible)
        {
            nuevoInfoVisible = false;
            nuevoLabel1.Text = string.Empty; // Oculta la información
        }
        else
        {
            nuevo.Bocina();
            string nuevoMethod = $"\nBocina: {nuevo.Bocina()}";
            nuevoLabel1.Text += nuevoMethod;
            nuevoInfoVisible = true;
        }
    }
    private void EncenderN(object sender, EventArgs e)
    {
        string nuevoMethod = nuevo.Encender();

        nuevoLabel1.Text = nuevoMethod;



    }
    private void ApagarN(object sender, EventArgs e)
    {

        string nuevoMethod = nuevo.Apagar();

        nuevoLabel1.Text = nuevoMethod;
    }
    private void AcelerarN(object sender, EventArgs e)
    {

        int nuevaVelocidad = nuevo.Acelerar(nuevo.FrenActual);

        if (nuevaVelocidad <= 180) // Verifica si la nueva velocidad es menor o igual a 200
        {

            string nuevoMethod = $"\nAcelerando a: {nuevaVelocidad} KM/H";
            nuevoLabel1.Text = nuevoMethod;
        }
        else
        {
            // Aquí puedes mostrar un mensaje indicando que se ha alcanzado la velocidad máxima
            string mensaje = "Se ha alcanzado la velocidad máxima de 180 KM/H";
            nuevoLabel1.Text = mensaje;
            nuevo.FrenActual -= 10;
        }
    }
    private void FrenarN(object sender, EventArgs e)
    {

        int nuevaVelocidad = nuevo.Frenar(nuevo.FrenActual);

        if (nuevaVelocidad >= 0) // Verifica si la nueva velocidad es menor o igual a 200
        {

            string nuevoMethod = $"\nAcelerando a: {nuevaVelocidad} KM/H";
            nuevoLabel1.Text = nuevoMethod;
        }
        else
        {
            // Aquí puedes mostrar un mensaje indicando que se ha alcanzado la velocidad máxima
            string mensaje = "No puedes frenar mas tu velocidad actual es de 0 KM/H";
            nuevoLabel1.Text = mensaje;
            nuevo.FrenActual += 10;
        }

    }
}