using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories
{
    public interface ICadastroRepository
    {
        CadastroRepository Update(int cadastroId, Cadastro novoCadastro);
    }
}