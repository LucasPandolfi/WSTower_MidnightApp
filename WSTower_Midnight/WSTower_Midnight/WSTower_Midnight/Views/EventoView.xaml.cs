using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTower_Midnight.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventoView : ContentPage
    {
        public EventoView()
        {
            InitializeComponent();
        }

        private void ButtonClicked_CadastrarEvento(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastrarEventoView());
        }
    }
}