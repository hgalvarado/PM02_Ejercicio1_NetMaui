namespace PM02_Ejercicio1.Views;

public partial class PageResultado : ContentPage
{
	public PageResultado(double result, string Operacion)
	{
		InitializeComponent();
		txtResultado.Text = "El resultado de la " +Operacion + " Es: " + result.ToString();
	}
}