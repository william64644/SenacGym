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
    public partial class frmAtividade : Form
    {
        private AlunoAtividade aluno;
        private Atividade atividade;
        public frmAtividade()
        {
            InitializeComponent();
            aluno = new AlunoAtividade();
            //atividade = new Atividade();
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

        private void carregarGridAtividade()
        {
            try
            {
                grdAtividade.DataSource = atividade.Consultar();
                // Ajuste das colunas conforme estrutura da classe Aluno
                grdAtividade.Columns[0].Visible = false; // Id
                grdAtividade.Columns[1].Visible = false; // Id
                grdAtividade.Columns[2].Visible = false; // Id
                grdAtividade.Columns[3].Visible = false; // Id
                grdAtividade.Columns[4].HeaderText = "Comentário";
                grdAtividade.Columns[5].HeaderText = "Séries";
                grdAtividade.Columns[6].HeaderText = "Repetições";
                grdAtividade.Columns[7].HeaderText = "Treino";

                //
                // Ajuste de largura
                grdAtividade.Columns[4].Width = 518;
                grdAtividade.Columns[5].Width = 48;
                grdAtividade.Columns[6].Width = 68;
                grdAtividade.Columns[7].Width = 58;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            aluno = new AlunoAtividade();
            aluno.pesquisa = txtPesquisa.Text;
            CarregarGridAluno();
        }

        private void grdAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                aluno = new AlunoAtividade();
                aluno.id = Convert.ToInt32(grdAluno.SelectedRows[0].Cells[0].Value);
                aluno.Consultar();
                txtNome.Text = aluno.nome;
                consultarAtividades();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAtividade_Load(object sender, EventArgs e)
        {
            aluno = new AlunoAtividade();
            aluno.pesquisa = txtPesquisa.Text;
            CarregarGridAluno();
        }

        private void consultarAtividades()
        {
            atividade = new Atividade();
            if (aluno.id != 0)
            {
                atividade.idAluno = aluno.id;
            }
            atividade.Consultar();
            carregarGridAtividade();
        }

    }
}
