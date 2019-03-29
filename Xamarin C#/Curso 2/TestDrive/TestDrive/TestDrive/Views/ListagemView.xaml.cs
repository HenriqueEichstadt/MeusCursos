using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrive.Models;
using Xamarin.Forms;

namespace TestDrive.Views
{
    public partial class ListagemView : ContentPage
    {

        // propriedade para conter a lista de veiculos
        public List<Veiculo> Veiculos { get; set; }

        public ListagemView()
        {
            InitializeComponent();
            this.Veiculos = new ListagemVeiculos().Veiculos;
            this.BindingContext = this;

        }

        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            Navigation.PushAsync(new DetalheView(veiculo));
        }
    }
}