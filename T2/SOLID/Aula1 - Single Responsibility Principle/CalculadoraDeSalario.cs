using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class CalculadoraDeSalario
    {
        public double calcula(Funcionario funcionario)
        {
            return funcionario.Cargo.Regra.Calcula(funcionario);
          
        }
    }
}
