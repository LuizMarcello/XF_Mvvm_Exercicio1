﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Mvvm_Exercicio1.ViewModels;

namespace XF_Mvvm_Exercicio1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlunosPage : ContentPage
    {
        public AlunosPage()
        {
            InitializeComponent();

            this.BindingContext = new AlunoViewModel();
        }
    }
}