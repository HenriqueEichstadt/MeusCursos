using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._7_interpolacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var contrato = new
            {
                Empresa = "Alura Serviços Hidráulicos Ltda.",
                Funcionario = "Mario Mario",
                Inicio = new DateTime(2019, 1, 1),
                Cargo = "encanador",
                Salario = 3108.45,
                InicioJornada = new DateTime(2018, 1, 10, 9, 0, 0),
                FimJornada = new DateTime(2018, 1, 10, 18, 0, 0)
            };

            string documento = 
                string.Format(
                $@"                                             CONTRATO INDIVIDUAL DE TRABALHO TEMPORÁRIO


            EMPREGADOR: {contrato.Empresa};

            EMPREGADO: {contrato.Funcionario}.


Pelo presente instrumento particular de contrato individual de trabalho, fica justo e contratado o seguinte:
 
Cláusula 1ª - O EMPREGADO prestará ao EMPREGADOR, a partir de {contrato.Inicio:D} e assinatura deste instrumento, seus trabalhos exercendo a função de {contrato.Cargo}, prestando pessoalmente o labor diário no período compreendido entre {contrato.InicioJornada:HH:mm} e {contrato.FimJornada:HH:mm}, e intervalo de 1 hora para almoço;

            Cláusula 2ª - Não haverá expediente nos dias de sábado, sendo prestado a compensação de horário semanal;

            Cláusula 3ª - O EMPREGADOR pagará mensalmente, ao EMPREGADO, a título de salário a importância de {contrato.Salario:C}, com os descontos previstos por lei;

            Cláusula 4ª - Estará o EMPREGADO subordinado a legislação vigente no que diz respeito aos descontos de faltas e demais sanções disciplinares contidas na Consolidação das Leis do Trabalho.

            Cláusula 5ª - O prazo de duração do contrato é de 2(dois) anos, contados a partir da assinatura pelos contratantes;

            Cláusula 6ª - O EMPREGADO obedecerá o regulamento interno da empresa, e filosofia de trabalho da mesma.


Como prova do acordado, assinam instrumento, afirmado e respeitando seu teor por inteiro, e firmam conjuntamente a este duas testemunhas, comprovando as razões descritas.


São Paulo, {DateTime.Now:D}
 
 
_______________________________________________________
{contrato.Empresa}


_______________________________________________________
{contrato.Funcionario}


_______________________________________________________
(Nome, R.G, Testemunha)


_______________________________________________________
(Nome, R.G, Testemunha)
 ");
            Console.WriteLine(documento);
            Console.ReadKey();
        }
    }
}