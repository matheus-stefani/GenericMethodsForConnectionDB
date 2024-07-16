using SpassoCasaERPDesktop.Constantes.BancoDeDados;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpassoCasaERPDesktop.Metodos.BancoDeDados
{
    internal class ManipulacaoString
    {

        public static string inserirString(DadosComponentes[] componentes)
        {
            StringBuilder queryInserir = new StringBuilder("(");

            //Começa em '1' porque o primeiro input e do id
            for (int i = 1; i < componentes.Length; i++)
            {
                string pegarValor = componentes[i].Valor;
                Tipo tipoComponente = componentes[i].TipoComponente;
                if (tipoComponente == Tipo.Inteiro)
                    queryInserir.Append(pegarValor);
                else
                    queryInserir.Append("'" + pegarValor + "'");
                
                if(i != componentes.Length-1) queryInserir.Append(",");
            }

            queryInserir.Append(")");

            return queryInserir.ToString();
        }

        public static string editarString(DadosComponentes[] valores, string colunas)
        {
            
            string colunasComValores = "";
            int contador = 1;
            for (int i = 0; i < colunas.Length; i++)
            {

                if (colunas[i] == ',')
                {
                    if (valores[contador].TipoComponente == Tipo.Inteiro)
                        colunasComValores += "=" + valores[contador].Valor;
                    else
                        colunasComValores += "=" + "'" + valores[contador].Valor + "'";
                    contador++;
                    if (contador == valores.Length)
                    {
                        colunasComValores += " WHERE ";
                        continue;
                    };
                    colunasComValores += ",";
                    continue;
                }
                colunasComValores += colunas[i];
                
            }
            colunasComValores += "=" + valores[0].Valor;

            
            return colunasComValores;
        }

        public static string tirarOuPegarID(string colunas, ID getOrDel)
        {
            StringBuilder id = new StringBuilder(colunas);


            for (int i = id.Length-1; i >= 0; i--)
            {    
                if (id[i] == ',')
                {
                    if(getOrDel == ID.TIRAR) return id.Remove(i, 3).ToString();
                    if(getOrDel == ID.PEGAR) return id.Remove(0, i+1).ToString();
                }
            }
            return "";
        }
    }
}
