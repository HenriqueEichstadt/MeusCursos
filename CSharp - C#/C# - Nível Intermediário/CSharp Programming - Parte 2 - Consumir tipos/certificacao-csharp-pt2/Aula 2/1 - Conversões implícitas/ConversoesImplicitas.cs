using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ConversoesImplicitas : IAulaItem
    {
        public void Executar()
        {
            // Conversão impícita:
            // Só conseguimos fazer uma conversão implícita quando utilizamos como variável de destino, uma variável 
            // que é um tipo base da classe que está sendo recebida, ou é uma interface implementa pela classe base,
            // ou é para um tipo primitivo com maior capacidade, seguindo a regra da tabela de conversões numéricas implícitas

            // Com tipos de Valor
            int inteiro = 2_123_456_789;
            long inteiroLongo = inteiro;
            Console.WriteLine($"inteiroLongo: {inteiroLongo}");

            //inteiro = inteiroLongo;

            // Com tipos de Referência
            Gato gato = new Gato();
            Animal animal = gato;
            Console.WriteLine($"animal.GetType(): {animal.GetType()}");
            IAnimal ianimal = gato;
            Console.WriteLine($"ianimal.GetType(): {ianimal.GetType()}");
        }
    }
}

