using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topico1.PropriedadesEAcessadores
{
    class Program
    {
        static void Main(string[] args)
        {
            ModificadoresDeVisibilidade();

        }

        public static void EncapsulamentoEProprieadesSomenteLeitura()
        {
            Funcionario funcionario = new Funcionario(1000);
            // funcionario.salario = 1000;
            // Console.WriteLine($"funcionario.salario: {funcionario.salario}");
            //
            // funcionario.salario = -1200;
            // Console.WriteLine($"funcionario.salario: {funcionario.salario}");

            //funcionario.Salario = 1200;
            Console.WriteLine($"funcionario.Salario: {funcionario.Salario}");
        }

        public static void ModificadoresDeVisibilidade()
        {
            Conta conta = new Conta();
            conta.Saldo = 1000;
            Console.WriteLine($"conta.Saldo: {conta.Saldo}");
        }
    }
}
