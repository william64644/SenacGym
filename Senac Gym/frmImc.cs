using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappySmile;

namespace Senac_Gym
{
    public partial class frmImc : Form
    {
        public frmImc()
        {
            InitializeComponent();
        }

        private void CarregarGrid()
        {
            //definimos um bloco try/catch para garantir a execução
            //do fluxo fora do nosso ambiente
            try
            {
                //Preenchemos o Grid com o resultado da consulta dos usuários
                grdDados.DataSource = imc.Consultar();
                //Ocultar colunas
                grdDados.Columns[0].Visible = false; //Id
                grdDados.Columns[1].Visible = false; //Senha
                //Cabeçalho das colunas
                grdDados.Columns[2].HeaderText = "Nome";
                grdDados.Columns[3].HeaderText = "Altura";
                grdDados.Columns[4].HeaderText = "Peso";
                grdDados.Columns[5].HeaderText = "Data";
                //Largura das colunas
                grdDados.Columns[2].Width = 100;
                grdDados.Columns[3].Width = 100;
                grdDados.Columns[4].Width = 100;
                grdDados.Columns[5].Width = 100;
            }
            catch (Exception ex)
            {
                //Caso ocorra algum erro fora do ambiente
                //Mostramos a mensagem de erro ao usuário
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Imc imc = new Imc();
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            //Resetamos o objeto       
            imc = new Imc();
            //Atribuímos o nome para pesquisa
            imc.nome = txtPesquisa.Text;
            //Chamamos o método para preencher o Grid com o resultado do filtro aplicado
            CarregarGrid();
        }
    }
}
