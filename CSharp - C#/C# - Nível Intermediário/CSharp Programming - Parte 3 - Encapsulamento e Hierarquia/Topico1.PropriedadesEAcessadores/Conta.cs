using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topico1.PropriedadesEAcessadores
{
    public class Conta
    {
        // Getters e Setters
        // public - Visível em todo o projeto ou projetos dependentes
        // internal - Visível apenas dentro do assembly do projeto onde a classe está
        // protected - Visível apenas em classes que estão herdando
        // private - Visível apenas dentro da própria classe onde foi criada, só pode ser alterada pelo código da própria classe.
        // removendo o { set; } - Só pode ser alterada dentro do contrutor, definindo um valor inicial.

        // Modificador de acesso da propriedade
        // public - Visível em todo o projeto ou projetos dependentes, qualquer classe consegue acessar e modificar a propriedade
        // internal - Somente o código do Assembly consegue acessar e modificar a propriedade
        // protected - Somente a classe e as classes derivadas acessam e modificam o valor da propriedade
        // private - Somente a classe conta tem acesso a leitura e gravação na propriedade
        public decimal Saldo { get; set; }

        public Conta()
        {
            this.Saldo = 1000;
            Console.WriteLine($"Saldo: {Saldo}");
        }

        void Sacar(decimal saque)
        {
            Saldo = Saldo - saque;
        }
    }
}
