using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoGrupoClasses
{
    public class ProdutoProcessado : ProdutoAlimentar
    {
        private string p_marca;
        private int p_unidadesEmbalagem;
        private int p_validade;

        public string Marca
        {
            get { return p_marca; }
            set { p_marca = value; }
        }

        public int UnidadesEmbalagem
        {
            get { return p_unidadesEmbalagem; }
            set { p_unidadesEmbalagem = value; }
        }

        public int Validade
        {
            get { return p_validade; }
            set { p_validade = value; }
        }

        // Devolve o total de calorias de um produto alimentar, tendo em conta o respetivo peso e unidades por embalagem
        public override double CalcNutricionalTotal()
        {
            double resultado = 0;
            resultado = base.CalcNutricionalTotal() * p_unidadesEmbalagem;
            return resultado;

        }

        // Devolve o PVP, que é a soma do custo, da margem de comercialização e o valor da embalagem
        public override double CalcPVP()
        {
            int precoExtraEmb = p_unidadesEmbalagem;
            double resultado = 0;
            resultado = base.CalcPVP() + precoExtraEmb;
            return resultado;
        }

        // Devolve se um produto processado é saudável, se não exceder os limites de lípidos e hidratos de carbono por 100g 
        public override bool ESaudavel()
        {
            if (VMLipidos <= 10 && VMHidratos <= 20)
                return true;
            else return false;
        }

        public ProdutoProcessado(string codigo, string nome, double peso, string marca) : base(codigo, nome, peso, 10)
        {
            p_unidadesEmbalagem = 1;
            p_validade = 1;
            p_marca = marca;
        }
    }
}
