using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WebServiceProfissoes.Model
{
    [DataContract]
    public class Profissional
    {
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Funcao { get; set; }
        [DataMember]
        public string Salario { get; set; }
        [DataMember]
        public string Codigo { get; set; }

    }
}
