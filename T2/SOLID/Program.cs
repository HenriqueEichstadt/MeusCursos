using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDeSalario cs = new CalculadoraDeSalario();
            Funcionario funcionario = new Funcionario(new Desenvolvedor(new DezOuVintePorcento()), 2000);
            double resultado;

            resultado = cs.calcula(funcionario);

            Console.WriteLine("O salário de um desenvolvedor que ganha 2000 bruto é:   " + resultado);
            Console.ReadKey();
        }
    }
}
