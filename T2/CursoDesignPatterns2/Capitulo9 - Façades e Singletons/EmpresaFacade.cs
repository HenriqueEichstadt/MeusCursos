using CursoDesignPatterns2.Capitulo8___Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Capitulo9___Façades_e_Singletons
{
    public class EmpresaFacade
    {
        public Cliente BuscaCliente(string cpf)
        {
            return new ClienteDAO().BuscaPorCpf(cpf);
        }

        public Fatura CriaFatura(Cliente cliente, double valor)
        {
            return new Fatura(cliente, valor);
        }

        public Cobranca GeraCobranca(Tipo tipo, Fatura fatura)
        {
            GeraCobranca cobranca = new Cobranca();
            cobranca.Emite();
            return cobranca;
        }
        public ContatoCLiente FazContato(Cliente cliente, Cobranca cobranca)
        {
            ContatoCliente contato = new ContatoCliente(cliente, cobranca);
            contato.Dispara();
            return contato;
        }
    }
}
