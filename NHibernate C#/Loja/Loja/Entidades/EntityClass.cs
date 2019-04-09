using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Loja.Entidades
{
    [DataContract]
    class EntityClass
    {
        [DataMember]
        public int Id { get; protected set; }
    }
}
}
