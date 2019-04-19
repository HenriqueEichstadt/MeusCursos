using ByteBank.Portal.Filtros;
using ByteBank.Portal.Infraestrutura.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Portal.Infraestrutura
{
    public class ManipuladorRequisicaoController
    {
        private readonly ActionBinder _actionBinder = new ActionBinder();
        private readonly FilterResolver _filterResolver = new FilterResolver();

        public void Manipular(HttpListenerResponse resposta, string path)
        {
            var partes = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            var controllerNome = partes[0];
            var actionNome = partes[1];

            var controllerNomeCompleto = $"ByteBank.Portal.Controller.{controllerNome}Controller";

            var controllerWrapper = Activator.CreateInstance("ByteBank.Portal", controllerNomeCompleto, new object[0]);
            var controller = controllerWrapper.Unwrap();

            //var methodInfo = controller.GetType().GetMethod(actionNome);
            var actionBindInfo = _actionBinder.ObterActionBindInfo(controller, path);

            var filterResult = _filterResolver.VerificarFiltros(actionBindInfo);

            var resultadoAction = (string)actionBindInfo.Invoke(controller);

            var buffer = Encoding.UTF8.GetBytes(resultadoAction);

            resposta.StatusCode = 200;
            resposta.ContentType = "text/html; charset=utf-8";
            resposta.ContentLength64 = buffer.Length;

            resposta.OutputStream.Write(buffer, 0, buffer.Length);
            resposta.OutputStream.Close();
        }

        internal void Manipular(object path)
        {
            throw new NotImplementedException();
        }
    }
}
