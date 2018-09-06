using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Portal.Infraestrutura.Binding
{
    public class ActionBinder
    {
        public MethodInfo ObterMethodInfo(object controller, string path)
        {

            var idxInterrogacao = path.IndexOf('?');
            var existeQueryString = idxInterrogacao >= 0;

            if (!existeQueryString)
            {
                var nomeAction = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries)[1];
                var methodInfo = controller.GetType().GetMethod(nomeAction);
                return new ActionBindInfo(methodInfo, Enumerable.Empty<ArgumentoNomeValor>());
                    
            }
            else
            {
                var nomeControllerComAction = path.Substring(0, idxInterrogacao);
                var nomeAction = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries)[1];
                var queryString = path.Substring(idxInterrogacao + 1);
                var tuplasNomeValor = ObterArgumentoNomeValores(queryString);
                var argumentos = tuplasNomeValor.Select(tupla => tupla.Nome).ToArray();

                var methodInfo = ObterMethodInfoAPartirDeNomeEArgumentos(nomeAction, argumentos, controller);
                return new ActionBindInfo(methodInfo, tuplasNomeValor);
            }
        }
         
        private IEnumerable<ArgumentoNomeValor> ObterArgumentoNomeValores(string queryString)
        {
            var tuplasNomeValor = queryString.Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var tupla in tuplasNomeValor)
            {
                var partesTuplas = queryString.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                yield return new ArgumentoNomeValor(partesTuplas[0], partesTuplas[1]);
            }

        }

        private MethodInfo ObterMethodInfoAPartirDeNomeEArgumentos(string nomeAction, string[] argumentos, object controller)
        {
            var argumentosCount = argumentos.Length;

            var bindingFlags =
                BindingFlags.Instance |
                BindingFlags.Static |
                BindingFlags.Public |
                BindingFlags.DeclaredOnly;

            var metodos = controller.GetType().GetMethods(bindingFlags);
            var sobrecargas = metodos.Where(metodo => metodo.Name == nomeAction);

            foreach (var sobrecarga in sobrecargas)
            {
                var parametros = sobrecarga.GetParameters();

                if (argumentosCount != parametros.Length)
                    continue;

                var match =
                    parametros.All(
                        parametro =>
                        argumentos.Contains(parametro.Name)
                        );

                if (match)
                {
                    return sobrecarga;
                }
            }
            throw new ArgumentException($"A sobrecarga do método {nomeAction} não foi encontrada!");
        }
    }
}
