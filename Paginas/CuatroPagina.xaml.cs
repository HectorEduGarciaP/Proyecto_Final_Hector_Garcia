using MauiApp1.Clases;

namespace MauiApp1.Paginas;

public partial class CuatroPagina : ContentPage
{
    private CuatroPorCuatro cuatroPorCuatro = new CuatroPorCuatro();
    private bool cuatroxInfoVisible = false;
    public CuatroPagina()
	{
		InitializeComponent();
        
        cuatroPorCuatro.Marca = "Toyota";
        cuatroPorCuatro.Modelo = "Prado";
        cuatroPorCuatro.Color = "Negra";
        cuatroPorCuatro.Anio = 2022;
        cuatroPorCuatro.Placa = "Prado123";
        cuatroPorCuatro.Tipo = "4x4";
        

        string cuatroPorCuatroInfo = $"Marca: {cuatroPorCuatro.Marca}\nModelo: {cuatroPorCuatro.Modelo}\nColor: {cuatroPorCuatro.Color}\nAño: {cuatroPorCuatro.Anio}\nPlaca: {cuatroPorCuatro.Placa}\nTipo: {cuatroPorCuatro.Tipo}";
        cuatroxLabel.Text = cuatroPorCuatroInfo;
    }

    private void OnRegresarClicked1(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }


    private void BocinarX(object sender, EventArgs e)
    {

        if (cuatroxInfoVisible)
        {
            cuatroxInfoVisible = false;
            cuatroxLabel1.Text = string.Empty; // Oculta la información
        }
        else
        {


            cuatroPorCuatro.Bocina();


            string cuatroxMethod = $"\nBocina: {cuatroPorCuatro.Bocina()}";

            cuatroxLabel1.Text += cuatroxMethod;

            cuatroxInfoVisible = true;
        }
    }



    private void EncenderX(object sender, EventArgs e)
    {

        string cuatroxMethod = cuatroPorCuatro.Encender();

        cuatroxLabel1.Text = cuatroxMethod;



    }
    private void ApagarX(object sender, EventArgs e)
    {

        string cuatroxMethod = cuatroPorCuatro.Apagar();

        cuatroxLabel1.Text = cuatroxMethod;
    }
    private void AcelerarX(object sender, EventArgs e)
    {

        int nuevaVelocidad = cuatroPorCuatro.Acelerar(cuatroPorCuatro.FrenActual);

        if (nuevaVelocidad <= 220) // Verifica si la nueva velocidad es menor o igual a 200
        {

            string cuatroxMethod = $"\nAcelerando a: {nuevaVelocidad} KM/H";
           cuatroxLabel1.Text = cuatroxMethod;
        }
        else
        {
            // Aquí puedes mostrar un mensaje indicando que se ha alcanzado la velocidad máxima
            string mensaje = "Se ha alcanzado la velocidad máxima de 220 KM/H";
           cuatroxLabel1.Text = mensaje;
            cuatroPorCuatro.FrenActual -= 10;
        }
    }
    private void FrenarX(object sender, EventArgs e)
    {

        int nuevaVelocidad = cuatroPorCuatro.Frenar(cuatroPorCuatro.FrenActual);

        if (nuevaVelocidad >= 0) // Verifica si la nueva velocidad es menor o igual a 200
        {

            string cuatroxMethod = $"\nAcelerando a: {nuevaVelocidad} KM/H";
           cuatroxLabel1.Text = cuatroxMethod;
        }
        else
        {
            // Aquí puedes mostrar un mensaje indicando que se ha alcanzado la velocidad máxima
            string mensaje = "No puedes frenar mas tu velocidad actual es de 0 KM/H";
           cuatroxLabel1.Text = mensaje;
            cuatroPorCuatro.FrenActual += 10;
        }

    }
}