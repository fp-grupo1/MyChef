using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoGrupoClasses
{
    public class ProdutoNatural : ProdutoAlimentar
    {
        private string p_origem;
        private bool p_biologico;

        public string Origem
        {
            get { return p_origem; }
            set { p_origem = value; }
        }

        public bool Biologico
        {
            get { return p_biologico; }
            set { p_biologico = value; }
        }

        //  Todos os produtos naturais são saudáveis
        public override bool ESaudavel()
        {
            return true;
        }

        public override string TipoToString()
        {
            return "Produto Natural";
        }

        public ProdutoNatural(string codigo, string nome, double peso) : base(codigo, nome, peso, 5)
        {
            p_origem = "Portugal";
            p_biologico = false;
        }
    }
}
