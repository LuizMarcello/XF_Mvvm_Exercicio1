using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Mvvm_Exercicio1.Views;

namespace XF_Mvvm_Exercicio1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AlunosPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
