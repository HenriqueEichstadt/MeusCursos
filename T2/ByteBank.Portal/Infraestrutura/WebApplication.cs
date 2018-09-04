using ByteBank.Portal.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Portal.Infraestrutura
{
    public class WebApplication
    {
        private readonly string[] _prefixos;

        public WebApplication(string[] prefixos)
        {
            if (prefixos == null)

                throw new ArgumentException(nameof(prefixos));

            _prefixos = prefixos;
        }

        public void Iniciar()
        {
            while (true)
                ManipularRequisicao();
        }

        private void ManipularRequisicao()
        {
            var httpListener = new HttpListener();

            foreach (var prefixo in _prefixos)
                httpListener.Prefixes.Add(prefixo);

            httpListener.Start();

            var contexto = httpListener.GetContext();
            var requisicao = contexto.Request;
            var resposta = contexto.Response;

            var path = requisicao.Url.AbsolutePath;

            if (Utilidades.EhArquivo(path))
            {
                var assembly = Assembly.GetExecutingAssembly();
                var nomeResource = Utilidades.ConverterPathParaNomeAssembly(path);
                var resourceStream = assembly.GetManifestResourceStream(nomeResource);

                if (resourceStream == null)
                {
                    resposta.StatusCode = 404;
                    resposta.OutputStream.Close();
                }
                else
                {
                    var bytesResource = new byte[resourceStream.Length];

                    resourceStream.Read(bytesResource, 0, (int)resourceStream.Length);

                    resposta.ContentType = Utilidades.ObterTipoDeConteudo(path);
                    resposta.StatusCode = 200;
                    resposta.ContentLength64 = resourceStream.Length;

                    resposta.OutputStream.Write(bytesResource, 0, bytesResource.Length);

                    resposta.OutputStream.Close();
                }
            }
            else if (path == "/Cambio/MXN")
            {
                var controller = new CambioController();
                var paginaConteudo = controller.MXN();
                var bufferArquivo = Encoding.UTF8.GetBytes(paginaConteudo);
                resposta.StatusCode = 200;
                resposta.ContentType = "text/html; charset=utf-8";
                resposta.ContentLength64 = bufferArquivo.Length;

                resposta.OutputStream.Write(bufferArquivo, 0, bufferArquivo.Length);
                resposta.OutputStream.Close();
            }

            else if (path == "/Cambio/USD")
            {
                var controller = new CambioController();
                var paginaConteudo = controller.USD();
                var bufferArquivo = Encoding.UTF8.GetBytes(paginaConteudo);
                resposta.StatusCode = 200;
                resposta.ContentType = "text/html; charset=utf-8";
                resposta.ContentLength64 = bufferArquivo.Length;

                resposta.OutputStream.Write(bufferArquivo, 0, bufferArquivo.Length);
                resposta.OutputStream.Close();
            }

            httpListener.Stop();
        }
    }
}
