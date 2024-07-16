using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpassoCasaERPDesktop.Constantes.BancoDeDados
{
    /*
     * Coloque o id sempre no final, o metodo de ManipualacaoString.tirarId() depende dessa logica;
     * 
     * 
     */
    internal static class Colunas
    {
        public static string Cliente { get; set; } = "nome,endereco,telefone,email,id";
    }
}
