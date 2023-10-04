namespace PM02_Ejercicio1
{
    public partial class MainPage : ContentPage
    {
        double numero1;
        double numero2;

        public MainPage()
        {
            InitializeComponent();
            
        
        }

        private async void sumar(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtNum1.Text);
            numero2 = Convert.ToDouble(txtNum2.Text);
            Models.calculos calculo = new Models.calculos();
            
            await Navigation.PushAsync(new Views.PageResultado(calculo.suma(numero1, numero2),"Suma"));
        }
        private async void restar(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtNum1.Text);
            numero2 = Convert.ToDouble(txtNum2.Text);
            Models.calculos calculo = new Models.calculos();

            await Navigation.PushAsync(new Views.PageResultado(calculo.resta(numero1, numero2), "Resta"));
        }
        private async void multiplicacion(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtNum1.Text);
            numero2 = Convert.ToDouble(txtNum2.Text);
            Models.calculos calculo = new Models.calculos();

            await Navigation.PushAsync(new Views.PageResultado(calculo.multiplicacion(numero1, numero2), "Multiplicacion"));
        }
        private async void division(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtNum1.Text);
            numero2 = Convert.ToDouble(txtNum2.Text);
            Models.calculos calculo = new Models.calculos();

            await Navigation.PushAsync(new Views.PageResultado(calculo.division(numero1, numero2), "Division"));
        }
    }
}