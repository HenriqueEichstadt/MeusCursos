using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Portal.Infraestrutura.Binding
{
    public class ActionBindInfo
    {
        public MethodInfo MethodInfo { get; private set; }
        public IReadOnlyCollection<ArgumentoNomeValor> TuplasArgumentoNomeValor { get; private set; }


        public ActionBindInfo(MethodInfo methodInfo, IEnumerable<ArgumentoNomeValor> tuplasArgumentoNomeValor)
        {
            MethodInfo = methodInfo ?? throw new ArgumentNullException(nameof(MethodInfo));

            if (tuplasArgumentoNomeValor == null)
            {
                throw new ArgumentNullException(nameof(tuplasArgumentoNomeValor));
            }

            TuplasArgumentoNomeValor =
                new ReadOnlyCollection<ArgumentoNomeValor>(tuplasArgumentoNomeValor.ToList());

        }
        public object Invoke(object controller)
        {
            MethidInfo
        }
    }
}
