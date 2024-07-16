using Microsoft.Win32.SafeHandles;
using MySql.Data.MySqlClient;
using SpassoCasaERPDesktop.Constantes.BancoDeDados;
using SpassoCasaERPDesktop.Metodos.BancoDeDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpassoCasaERPDesktop
{
  
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            inputNomeS.MaxLength = 1;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Crud.inserir(Tabela.Cliente, Colunas.Cliente, getValComponentes());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Crud.editar(Tabela.Cliente, Colunas.Cliente, getValComponentes());
        }



        private DadosComponentes[] getValComponentes()
        {
            DadosComponentes[] getValuesComponentes =
                         {new DadosComponentes(inputIdN.Text,Tipo.Inteiro),
                          new DadosComponentes(inputNomeS.Text,Tipo.String),
                          new DadosComponentes(inputEndS.Text,Tipo.String),
                          new DadosComponentes(inputTelefoneS.Text, Tipo.String),
                          new DadosComponentes(inputEmailS.Text, Tipo.String)};

            return getValuesComponentes;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Crud.deletar(Tabela.Cliente, Colunas.Cliente, getValComponentes());
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == ',')
            {

                var a = Encoding.ASCII.GetBytes(e.KeyChar.ToString());


                MessageBox.Show(a[0].ToString());
                
                e.Handled = true;
                
                return;
            }
            
        }

        private void inputValor_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void inputValor_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
