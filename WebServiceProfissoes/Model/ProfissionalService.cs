using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceProfissoes.Interface;
using WebServiceProfissoes.DAO;
using WebServiceProfissoes.Model;

namespace WebServiceProfissoes.Model
{
    public class ProfissionalService : IProfissionalService
    {
        public bool Adicionar(string nome, string funcao, string salario, string codigo)
        {
            Profissional p = new Profissional();
            p.Nome = nome;
            p.Funcao = funcao;
            p.Salario = salario;
            p.Codigo = codigo;

            ProfissionalDao proDao = new ProfissionalDao();
           proDao.Adicionar(p);

            return true;
        }

        public Profissional BuscarPorCodigo(string codigo)
        {
            ProfissionalDao proDao = new ProfissionalDao();
            return proDao.BuscarPorCodigo(codigo);
        }

        public List<Profissional> ListaProfissionais()
        {
            return ProfissionalDao.profissional;
        }
    }
}
