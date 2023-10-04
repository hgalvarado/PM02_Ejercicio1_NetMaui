namespace PM02_Ejercicio1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new MainPage());//Creamos esta linea para habilitar la navegacion entre pantallas

        }
    }
}