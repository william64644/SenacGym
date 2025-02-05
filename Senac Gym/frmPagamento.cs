using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senac_Gym
{
    public partial class frmPagamento : Form
    {
        private Pagamento pagamnto;
        private Aluno aluno;
        private Plano plano;
        public frmPagamento()
        {
            InitializeComponent();
            pagamnto = new Pagamento();
            aluno = new Aluno();
            plano = new Plano();
            carregarPlano();
            CarregarGridAluno();
        }

        private void carregarPlano()
        {
            try
            {
                //Instanciamos o objeto
                plano = new Plano();
                //Carregamos o ComboBox com o resultado da consulta dos Tipos de Cliente (DataTable)
                cboPlano.DataSource = plano.Consultar();
                //Definimos o valor a ser exibido para o usuário
                cboPlano.DisplayMember = "nome";
                //Definimos o valor a ser armazenado após o usuário selecionar um item
                cboPlano.ValueMember = "id";
                //Definimos que o ComboBox irá ser iniciado sem nenhuma opção escolhida
                cboPlano.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                //Caso ocorra algum erro fora do ambiente
                //Enviamos o erro para quem chamou o método
                throw new Exception(ex.Message);
            }
        }

        private void CarregarGridAluno()
        {
            try
            {
                grdAluno.DataSource = aluno.Consultar();
                // Ajuste das colunas conforme estrutura da classe Aluno
                grdAluno.Columns[0].Visible = false; // Id
                grdAluno.Columns[1].HeaderText = "Nome";
                grdAluno.Columns[2].HeaderText = "Telefone";
                grdAluno.Columns[3].HeaderText = "E-mail";


                // Ajuste de largura
                grdAluno.Columns[1].Width = 364;
                grdAluno.Columns[2].Width = 89;
                grdAluno.Columns[3].Width = 226;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            aluno = new Aluno();
            aluno.nome = txtPesquisa.Text;
            CarregarGridAluno();
        }

        private void grdAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                aluno = new Aluno();
                aluno.id = Convert.ToInt32(grdAluno.SelectedRows[0].Cells[0].Value);
                aluno.Consultar();
                txtNome.Text = aluno.nome;
                pagamnto.idAluno = aluno.id;
                grdPagamento.DataSource = pagamnto.Consultar();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdPagamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
