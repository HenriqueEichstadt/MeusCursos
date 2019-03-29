using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrive.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheView : ContentPage
    {


        public Veiculo Veiculo { get; set; }

        public string TextoFreioABS
        {
            get
            {
                return string.Format("Freio ABS - R$ {0}", Veiculo.FREIO_ABS);
            }
        }

        public string TextoArCondicionado
        {
            get
            {
                return string.Format("Ar Condicionado - R$ {0}", Veiculo.AR_CONDICIONADO);
            }
        }

        public string TextoMp3Player
        {
            get
            {
                return string.Format("MP3 Player - R$ {0}", Veiculo.MP3_PLAYER);
            }
        }

        public bool TemFreioABS
        {
            get
            {
                return Veiculo.TemFreioABS;
            }
            set
            {
                Veiculo.TemFreioABS = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
       

            }
        }

        public bool TemArCondicionado
        {
            get
            {
                return Veiculo.TemArCondicionado;
            }
            set
            {
                Veiculo.TemArCondicionado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));


            }
        }

        public bool TemMp3Player
        {
            get
            {
                return Veiculo.TemMP3Player;
            }
            set
            {
                Veiculo.TemMP3Player = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));


            }
        }

        public string ValorTotal
        {
            get
            {
                return Veiculo.PrecoTotalFormatado;
            }
        }

        public DetalheView(Veiculo veiculo)
        {
            InitializeComponent();
            this.Title = veiculo.Nome;
            this.Veiculo = veiculo;
            this.BindingContext = this;
        }

        private void buttonProximo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendamentoView(this.Veiculo));
        }
    }
}