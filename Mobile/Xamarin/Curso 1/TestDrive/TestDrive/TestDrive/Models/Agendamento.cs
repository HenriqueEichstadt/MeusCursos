using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrive.Models
{
    public class Agendamento
    {
        public Veiculo Veiculo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        private DateTime dataAgendamento = DateTime.Today;
        public DateTime DataAgendamento { get => dataAgendamento; set => dataAgendamento = value; }

        public TimeSpan HoraAgendamento { get; set; }
    }
}
