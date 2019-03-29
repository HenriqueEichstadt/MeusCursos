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
        private const int FREIO_ABS = 800;
        private const int AR_CONDICIONADO = 1000;
        private const int MP3_PLAYER = 500;

        public Veiculo Veiculo { get; set; }

        public string TextoFreioABS
        {
            get
            {
                return string.Format("Freio ABS - R$ {0}", FREIO_ABS);
            }
        }

        public string TextoArCondicionado
        {
            get
            {
                return string.Format("Ar Condicionado - R$ {0}", AR_CONDICIONADO);
            }
        }

        public string TextoMp3Player
        {
            get
            {
                return string.Format("MP3 Player - R$ {0}", MP3_PLAYER);
            }
        }

        // Mudar valor na view caso selecionar opção Freio ABS
        bool temFreioABS;
        public bool TemFreioABS
        {
            get
            {
                return temFreioABS;
            }
            set
            {
                temFreioABS = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
       

            }
        }

        // Mudar valor na view caso selecionar opção Ar Condicionado
        bool temArCondicionado;
        public bool TemArCondicionado
        {
            get
            {
                return temArCondicionado;
            }
            set
            {
                temArCondicionado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));


            }
        }

        // Mudar valor na view caso selecionar opção MP3 Player
        bool temMp3Player;
        public bool TemMp3Player
        {
            get
            {
                return temMp3Player;
            }
            set
            {
                temMp3Player = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));


            }
        }

        // Mostra o valor total
        public string ValorTotal
        {
            get
            {
                return string.Format("Valor Total: R$ {0}",
                    Veiculo.Preco
                    + (TemFreioABS ? FREIO_ABS : 0)
                    + (TemArCondicionado ? AR_CONDICIONADO : 0)
                    + (TemMp3Player ? MP3_PLAYER : 0)
                    );
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