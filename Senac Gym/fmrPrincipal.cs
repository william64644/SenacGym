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
    public partial class frmPrincipal : Form
    {

        private void AbrirForm(Form form)
        {
            if (Application.OpenForms[form.Name] != null)
            {
                Application.OpenForms[form.Name].Activate();
            }
            else
            {
                form.Show();
            }
        }
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuCadastroUsuario_Click(object sender, EventArgs e)
        {
            //No click do menu, chamamos o método para abrir o formulário
            AbrirForm(new frmUsuario());
        }

        private void btnConsultaIMC_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmImc());
        }
    }
}
