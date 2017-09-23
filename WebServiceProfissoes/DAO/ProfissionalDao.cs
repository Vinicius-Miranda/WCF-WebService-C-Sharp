using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceProfissoes.Model;

namespace WebServiceProfissoes.DAO
{
    public class ProfissionalDao
    {
        public static List<Profissional> profissional = new List<Profissional>();

        public void Adicionar(Profissional p)
        {
            ProfissionalDao.profissional.Add(p);

        }

        public Profissional BuscarPorCodigo(string codigo) {
            var resultado = ProfissionalDao.profissional.Where(p => p.Codigo.Equals(codigo)).FirstOrDefault();
            return resultado;
        } 
    }
}
