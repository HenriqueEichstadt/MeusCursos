using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Portal.Infraestrutura.IoC
{
    public class ContainerSimples : IContainer
    {
        private readonly Dictionary<Type, Type> _mapaDeTipos = new Dictionary<Type, Type>();

        /// <summary>
        /// Registar (typeof(ICambioService)), typeof(CambioServiceTeste) );
        /// </summary>
        public void Registrar(Type tipoOrigem, Type tipoDestino)
        {
            if (_mapaDeTipos.ContainsKey(tipoOrigem))
                throw new InvalidOperationException($"O tipo já está mapeado");

            VerificarHierarquiaOuLancarExcessao(tipoOrigem, tipoDestino);

            _mapaDeTipos.Add(tipoOrigem, tipoDestino);
        }

        public void Registrar<TOrigem, TDestino>() where TDestino : TOrigem
        {
            if (_mapaDeTipos.ContainsKey(typeof(TOrigem)))
                throw new InvalidOperationException("Tipo já mapeado");

            _mapaDeTipos.Add(typeof(TOrigem) ,typeof(TDestino));
        }

        /// <summary>
        /// Recuperar( typeof(ICambioService) ) // deve retornar uma instância do tipo CambioServiceTeste
        /// </summary>
        public object Recuperar(Type tipoOrigem)
        {
            var tipoOrigemFoiMapado = _mapaDeTipos.ContainsKey(tipoOrigem);
            if (tipoOrigemFoiMapado)
            {
                var tipoDestino = _mapaDeTipos[tipoOrigem];
                return Recuperar(tipoDestino);
            }

            var construtores = tipoOrigem.GetConstructors();
            var construtorSemParametros =
                construtores.FirstOrDefault(construtor => construtor.GetParameters().Any() == false);

            if(construtorSemParametros != null)
            {
                var instanciaDeConstrutorSemParametro = construtorSemParametros.Invoke(new object[0]);
                return instanciaDeConstrutorSemParametro;
            }

            var construtorQueVamosUsar = construtores[0];
            var parametrosDoConstrutor = construtorQueVamosUsar.GetParameters();
            var valoresDeParametros = new object[parametrosDoConstrutor.Count()];

            for(int i = 0; i < parametrosDoConstrutor.Count(); i++)
            {
                var parametro = parametrosDoConstrutor[i];
                var tipoParametro = parametro.ParameterType;

                valoresDeParametros[i] = Recuperar(tipoParametro);
            }

            var instanciaDeContrutorComParametros = construtorQueVamosUsar.Invoke(valoresDeParametros);
            return instanciaDeContrutorComParametros;
        }

        private void VerificarHierarquiaOuLancarExcessao(Type tipoOrigem, Type tipoDestino)
        {
            // verificar se tipoDestino herda ou implementa o tipoOrigem
            if (tipoOrigem.IsInterface)
            {
                var tipoDestinoImplementaInterface =
                    tipoDestino
                    .GetInterfaces()
                    .Any(tipoInterface => tipoInterface == tipoOrigem);

                if (!tipoDestinoImplementaInterface)
                {
                    throw new InvalidOperationException("O tipo destino não implementa a interface");
                }
            }
            else
            {
                var tipoDestinoHerdaOrigem = tipoDestino.IsSubclassOf(tipoOrigem);

                if (!tipoDestinoHerdaOrigem)
                {
                    throw new InvalidOperationException("O tipo destino não herda o tipo origem");
                }
            }
        }
    }
}
