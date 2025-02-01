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
                grdAtividade.Columns[7].HeaderText = "Comentário";
                grdAtividade.Columns[8].HeaderText = "Séries";
                grdAtividade.Columns[9].HeaderText = "Repetições";
                grdAtividade.Columns[10].HeaderText = "Treino";

                //
                // Ajuste de largura
                grdAtividade.Columns[7].Width = 518;
                grdAtividade.Columns[8].Width = 48;
                grdAtividade.Columns[9].Width = 68;
                grdAtividade.Columns[10].Width = 58;

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
                LimparAtividade();
                aluno = new AlunoAtividade();
                aluno.id = Convert.ToInt32(grdAluno.SelectedRows[0].Cells[0].Value);
                aluno.Consultar();
                txtNome.Text = aluno.nome;
                atividade = new Atividade();
                atividade.idAluno = aluno.id;
                carregarGridAtividade();

                
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
            cboMusculo.DataSource = Musculo.Consultar();
            cboMusculo.DisplayMember = "nome";
            cboMusculo.ValueMember = "id";
            cboMusculo.SelectedIndex = -1;

            cboExercicio.DataSource = Exercicio.Consultar();
            cboExercicio.DisplayMember = "nome";
            cboExercicio.ValueMember = "id";
            cboExercicio.SelectedIndex = -1;
        }

        private void preencherFormularioAtividade()
        {
            cboTreino.Text = atividade.treino;
            cboExercicio.Text = atividade.exercicio;
            cboMusculo.Text = atividade.musculo;
            txtNome.Text = atividade.aluno;
            txtObservacao.Text = atividade.comentario;
            txtRepeticao.Text = atividade.repeticao.ToString();
            txtSerie.Text = atividade.serie.ToString();
           
        }

        private void PreencherClasse()
        {
            atividade.idMusculo = (int)cboMusculo.SelectedValue;
            atividade.idExercicio = (int)cboExercicio.SelectedValue;
            atividade.idAluno = aluno.id;
            atividade.comentario = txtObservacao.Text;
            atividade.serie = int.Parse(txtSerie.Text);
            atividade.repeticao = int.Parse(txtRepeticao.Text);
            atividade.treino = cboTreino.Text;
        }

        private void grdAtividade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            atividade = new Atividade();

            atividade.id = Convert.ToInt32(grdAtividade.SelectedRows[0].Cells[0].Value);

            atividade.Consultar();
            preencherFormularioAtividade();
        }


        private void LimparCampos()
        {
            LimparAluno();
            LimparAtividade();
        }

        private void LimparAluno()
        {
            // Limpa os campos de texto relacionados ao aluno
            txtNome.Text = string.Empty;

            // Limpa a seleção do grid de alunos
            grdAluno.DataSource = null;
            grdAluno.ClearSelection();
            grdAluno.Rows.Clear();

            // Limpa a pesquisa
            txtPesquisa.Text = string.Empty;

            // Limpa a instância de aluno
            aluno = new AlunoAtividade();
            
        }
        private void LimparAtividade()
        {
            // Limpa os campos de texto relacionados à atividade
            txtObservacao.Text = string.Empty;
            txtRepeticao.Text = string.Empty;
            txtSerie.Text = string.Empty;

            // Limpa os comboboxes relacionados à atividade
            cboMusculo.SelectedIndex = -1;
            cboExercicio.SelectedIndex = -1;
            cboTreino.SelectedIndex = -1;

            // Limpa a seleção do grid de atividades
            grdAtividade.DataSource = null;
            grdAtividade.ClearSelection();
            grdAtividade.Rows.Clear();

            // Limpa a instância de atividade
            atividade = new Atividade();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            PreencherClasse();
            atividade.Gravar();
            atividade.id = 0;
            carregarGridAtividade();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }



        private void cboTreino_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cboTreino_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cboTreino_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboTreino_SelectedIndexChanged(object sender, EventArgs e)
        {
            atividade = new Atividade();

            atividade.idAluno = aluno.id;
            atividade.treino = cboTreino.Text;
            grdAtividade.DataSource = atividade.Consultar();
            preencherFormularioAtividade();
        }
    }
}
