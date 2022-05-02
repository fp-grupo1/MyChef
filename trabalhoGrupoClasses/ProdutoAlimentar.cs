using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoGrupoClasses
{
    public abstract class ProdutoAlimentar
    {
        private string p_idCod;
        private string p_nome;
        private double p_custo;
        private double p_vMProteinas;
        private double p_vMLipidos;
        private double p_vMHidratos;
        private bool p_alergenio;
        private double p_peso;
        private int p_numDistribuidores;
        private string p_nomeDistribuidorPrincipal;
        private int p_numMaxDistribuidores;

        //Fazer validação de valores nas propriedades.
        public string IdCod
        {
            get { return p_idCod; }
        }

        public string Nome
        {
            get { return p_nome; }
            set { p_nome = value; }
        }

        public double Custo
        {
            get { return p_custo; }
            set { p_custo = value; }
        }

        // g/100g
        public double VMProteinas
        {
            get { return p_vMProteinas; }
            set { p_vMProteinas = value; }
        }

        // g/100g
        public double VMLipidos
        {
            get { return p_vMLipidos; }
            set { p_vMLipidos = value; }
        }

        // g/100g
        public double VMHidratos
        {
            get { return p_vMHidratos; }
            set { p_vMHidratos = value; }
        }

        public bool Alergenios
        {
            get { return p_alergenio; }
            set { p_alergenio = value; }
        }

        public double Peso
        {
            get { return p_peso; }
            set { p_peso = value; }
        }

        public int NumDistribuidores
        {
            get { return p_numDistribuidores; }
        }

        public string NomeDistribuidorPrincipal
        {
            get { return p_nomeDistribuidorPrincipal; }
        }

        public int NumMaxDistribuidores
        {
            get { return p_numMaxDistribuidores; }
        }

        // Métodos


        // Devolve o número de calorias por 100g de produto através da soma dos macronutrientes presentes
        public double CalcNutricionalMedio()
        {
            
            int lipidos = 9;
            int proteina = 4;
            int hidratos = 4;
            double resultado = 0;
            resultado = p_vMLipidos * lipidos +p_vMHidratos * hidratos + p_vMProteinas * proteina;
            return resultado;
        }

        // Devolve o total de calorias de um produto alimentar, tendo em conta o seu peso
        public virtual double CalcNutricionalTotal()
        {            
            double resultado = 0;
            resultado = CalcNutricionalMedio() * p_peso / 100;
            return resultado;
        }

        // Devolve a margem de comercialização de um produto, correspondente a 10% do custo
        public virtual double CalcMargem()
        {            
            double resultado = 0;
            resultado = p_custo * 0.1;
            return resultado;
        }

        // Devolve o PVP, que é a soma do custo com a margem de comercialização
        public virtual double CalcPVP()
        {           
            double resultado = 0;
            resultado = p_custo + CalcMargem();
            return resultado;
        }

        // É implementado nas classes filhas, devolve se um produto é saudável
        public abstract bool ESaudavel();

        // Devolve o sucesso ou não do registo de um novo distribuidor,
        // incrementando o número de distribuidores se não ultrapassar o número máximo de distribuidores
        public bool RegistarDistribuidor()
        {            
            if(NumDistribuidores < NumMaxDistribuidores)
            {
                p_numDistribuidores++;
                return true;
            } else return false;
            
        }

        // Devolve o sucesso ou não do registo de um novo distribuidor,
        // incrementando o número de distribuidores se não ultrapassar o número máximo de distribuidores
        private bool RemoverDistribuidor()
        {
            if (NumDistribuidores == NumMaxDistribuidores)
            {
                p_numDistribuidores--;
                return true;
            }
            else return false;

        }

        // Recebendo um nome e o custo do produto, incrementando o número de distribuidores se não ultrapassar o número máximo de distribuidores
        // Devolve o sucesso de atualizar o distribuidor principal, caso o custo seja inferior ao custo do distribuidor atual
        public bool RegistarDistribuidor(string nome, double custo)
        {           
            if (custo < p_custo)
            {
                RemoverDistribuidor();
                p_custo = custo;
                p_nomeDistribuidorPrincipal = nome;               
            }

            return RegistarDistribuidor();
        }

        public ProdutoAlimentar(string codigo, string nome, double peso, int maxDistribuidores)
        {
            p_idCod = codigo;
            p_nome = nome;
            p_custo = 0;
            p_vMProteinas = 0;
            p_vMLipidos = 0;
            p_vMHidratos = 0;
            p_alergenio = true;            
            p_peso = peso;
            p_numDistribuidores = 0;
            p_nomeDistribuidorPrincipal = "";
            p_numMaxDistribuidores = maxDistribuidores;
        }
    }
}
