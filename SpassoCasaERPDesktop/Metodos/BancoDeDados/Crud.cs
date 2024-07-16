using MySql.Data.MySqlClient;
using SpassoCasaERPDesktop.Constantes.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpassoCasaERPDesktop.Metodos.BancoDeDados
{
    internal static class Crud
    {

        static MySqlConnection conn;

        public static void inserir(string[] tabela, string colunas, DadosComponentes[] componentes)
        {

            colunas = ManipulacaoString.tirarOuPegarID(colunas,ID.TIRAR);

            string query = "INSERT INTO " + tabela[0] + " (" + colunas + ") VALUES " + ManipulacaoString.inserirString(componentes);

            conexao(query, tabela[1], "inserido(a)", "inserir", CRUD.INSERIR);

        }

        public static void editar(string[] tabela, string colunas, DadosComponentes[] componentes)
        {

            string query = "UPDATE " + tabela[0] + " SET " + ManipulacaoString.editarString(componentes,colunas);

            conexao(query, tabela[1], "editado(a)", "editar", CRUD.EDITAR);

        }

        public static void deletar(string[] tabela, string colunas, DadosComponentes[] componentes)
        {
            colunas = ManipulacaoString.tirarOuPegarID(colunas, ID.PEGAR);

            string query = "DELETE FROM " + tabela[0]+ " WHERE " + colunas + "=" + componentes[0].Valor;

            conexao(query, tabela[1], "deletado(a)", "deletar", CRUD.DELETAR);

        }



        public static void conexao(string query, string exibirTabela,string sucesso,string erro, CRUD metodo)
        {
                try
                {
                    conn = new MySqlConnection(Config.conexao);

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    conn.Open();

                    int rowsAfetadas = -1;

                    if(metodo == CRUD.INSERIR || metodo == CRUD.DELETAR || metodo == CRUD.EDITAR)
                        rowsAfetadas = cmd.ExecuteNonQuery();

                    if(rowsAfetadas == 0 && (metodo == CRUD.INSERIR || metodo == CRUD.EDITAR || metodo == CRUD.DELETAR)) 
                        throw new FormatException("Ocorreu algum erro no banco de dados ao "+ erro +" o(a) "+ exibirTabela);

                    MessageBox.Show(exibirTabela + " " + sucesso +" com sucesso!");

                }
                catch(FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao "+ erro + " " + exibirTabela);
                }
                finally
                {
                    conn.Close();
                }
            }
        

     
    }
}
