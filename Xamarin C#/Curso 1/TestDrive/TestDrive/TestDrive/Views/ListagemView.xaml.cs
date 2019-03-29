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


            // inicializar a lista de veículos
            this.Veiculos = new List<Veiculo>
            {
                new Veiculo { Nome = "Azera V6", Preco = 60000 },
                new Veiculo { Nome = "Fiesta 2.0", Preco = 50000},
                new Veiculo { Nome = "HB20 S", Preco = 40000},
            };

            this.BindingContext = this;

        }

        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            Navigation.PushAsync(new DetalheView(veiculo));
        }
    }
}