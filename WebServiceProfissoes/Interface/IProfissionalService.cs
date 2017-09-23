using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceProfissoes.DAO;
using System.ServiceModel;
using System.ServiceModel.Web;
using WebServiceProfissoes.Model;

namespace WebServiceProfissoes.Interface
{
    [ServiceContract]
    public interface IProfissionalService
    {

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "addProfissional/{Nome}&{Funcao}&{Salario}&{Codigo}")]
        bool Adicionar(string nome, string funcao, string salario, string codigo);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "buscarPorCodigo/{codigo}")]
        Profissional BuscarPorCodigo(string codigo);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "listarProfissionais/")]
        List<Profissional> ListaProfissionais();
    }
}
