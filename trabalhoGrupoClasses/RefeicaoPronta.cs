using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoGrupoClasses
{
    public class RefeicaoPronta : ProdutoProcessado
    {
        private string p_modoPreparacao;
        private int p_tempoPreparacao;
        private bool p_gourmet;
        


        public string ModoPreparacao
        {
            get { return p_modoPreparacao; }
            set { p_modoPreparacao = value; }
        }

        public int TempoPreparacao
        {
            get { return p_tempoPreparacao; }
            set { p_tempoPreparacao = value; }
        }

        public bool Gourmet
        {
            get { return p_gourmet; }
            set { p_gourmet = value; }
        }

        // Devolve a margem de comercialização, caso seja uma refeição gourmet, a margem é de 20%
        public override double CalcMargem()
        {
            double resultado = 0;
            if (Gourmet) 
            {        
                resultado = Custo * 0.2;
            }
            else resultado = base.CalcMargem();
            return resultado;
        }

        // Devolve se é saudável, se as refeições prontas não excederem 800 calorias por dose
        public override bool ESaudavel()
        {
            double CaloriasTotal = base.CalcNutricionalTotal() / UnidadesEmbalagem;
            bool resultado = false;

            if (CaloriasTotal <= 800 && base.ESaudavel())
            {
                resultado = true;
            }
            else resultado = false;
            return resultado;
        }
        public override string TipoToString()
        {
            return "Refeição Pronta";
        }
        public RefeicaoPronta(string codigo, string nome, double peso, string marca) : base(codigo, nome, peso, marca)
        {
            p_modoPreparacao = "sem informação adicional";
            p_tempoPreparacao = 180;
            p_gourmet = false;            
        }
    }
}
