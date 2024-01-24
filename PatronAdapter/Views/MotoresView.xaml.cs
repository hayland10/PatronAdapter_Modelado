using PatronAdapter.Models;

namespace PatronAdapter.Views;

public partial class MotoresView : ContentPage
{
	public MotoresView()
	{
		InitializeComponent();
	}

    private void disel_Clicked(object sender, EventArgs e)
    {
		MotorDiesel disel = new MotorDiesel();
		string diselArranca = disel.Arrancar();
        string diselAcelera = disel.Acelerar();
		string diselDetiene = disel.Detener();
		string diselCarga = disel.cargarCombustible();

		DisplayAlert("MOTOR DISEL",$"{diselArranca},{diselAcelera},{diselDetiene},{diselCarga}","OK");

    }

    private void super_Clicked(object sender, EventArgs e)
    {
        MotorSuper super = new MotorSuper();
        string superArranca = super.Arrancar();
        string superAcelera = super.Acelerar();
        string superDetiene = super.Detener();
        string supercarga = super.cargarCombustible();

        DisplayAlert("MOTOR DISEL", $"{superArranca},{superAcelera},{superDetiene},{supercarga}", "OK");
    }

    private void electric_Clicked(object sender, EventArgs e)
    {
       MotorElectricoAdapter electric= new MotorElectricoAdapter();
        string elecArranca = electric.Arrancar();
        string elecAcelera = electric.Acelerar();
        string elecDetiene = electric.Detener();
        string seleccarga = electric.cargarCombustible();

        DisplayAlert("MOTOR DISEL", $"{elecArranca},{elecAcelera},{elecDetiene},{seleccarga}", "OK");
    }
}