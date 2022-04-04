using System;
using System.Collections.Generic;
using System.Text;
using TestDrive.Models;

namespace TestDrive.ViewModels
{
    public class ListagemViewModel
    {
        public List<Veiculo> Veiculos { get; set; }

        public ListagemViewModel()
        {
            Veiculos = new ListagemVeiculos().GetVeiculos();
        }

    }
}
