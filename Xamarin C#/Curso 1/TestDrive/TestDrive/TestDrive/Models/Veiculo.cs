using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrive.Models
{
    public class Veiculo
    {
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string PrecoFormatado
        {
            get { return string.Format("R$ {0}", Preco);  }
        }
    }
}
