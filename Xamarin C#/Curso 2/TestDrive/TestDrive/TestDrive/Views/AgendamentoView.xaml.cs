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
	public partial class AgendamentoView : ContentPage
	{
        public Agendamento Agendamento { get; set; }

        public Veiculo Veiculo
        {
            get
            {
                return Agendamento.Veiculo;
            }
            set
            {
                Agendamento.Veiculo = value;
            }
        }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        private DateTime dataAgendamento = DateTime.Today;
        public DateTime DataAgendamento { get => dataAgendamento; set => dataAgendamento = value; }
       
        public TimeSpan HoraAgendamento { get; set; }

        public AgendamentoView (Veiculo veiculo)
		{
			InitializeComponent ();
            this.Title = veiculo.Nome;
            this.Veiculo = veiculo;
            this.BindingContext = this;
            
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Agendamento",
            string.Format(
                            @"Nome: {0}
                            Fone: {1}
                            E-mail: {2}
                            Data Agendamento: {3}
                            Hora Agendamento:{4}",
            Nome, Telefone, Email, DataAgendamento.ToString("dd/MM/yyy"), HoraAgendamento), "OK");
        }
    }
}