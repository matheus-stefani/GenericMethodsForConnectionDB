using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpassoCasaERPDesktop.Constantes.BancoDeDados
{
    internal class DadosComponentes
    {
        public string Valor { get; set; }
        public Tipo TipoComponente { get; set; }

        public DadosComponentes(string valor, Tipo tipoComponente)
        {
            Valor = valor;
            TipoComponente = tipoComponente;
        }

    }

    enum Tipo
    {
        Inteiro,
        Decimal,
        String,
        Date,
        DateTime,
        Float
    }

}
