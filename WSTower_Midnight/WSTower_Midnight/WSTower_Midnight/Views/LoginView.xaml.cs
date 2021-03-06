﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTower_Midnight.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void ButtonClicked_Cadastro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroView());
        }

        private void ButtonClicked_Login(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrincipalView());
        }
    }
}