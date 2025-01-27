namespace Senac_Gym
{
    partial class frmImc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGravar = new System.Windows.Forms.Button();
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.grpDImc = new System.Windows.Forms.GroupBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblAnos = new System.Windows.Forms.Label();
            this.txtConfirmacao = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblImc = new System.Windows.Forms.Label();
            this.txtImc = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.grpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            this.grpPesquisa.SuspendLayout();
            this.grpDImc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(10, 318);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(114, 41);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.grdDados);
            this.grpLista.Location = new System.Drawing.Point(10, 66);
            this.grpLista.Name = "grpLista";
            this.grpLista.Size = new System.Drawing.Size(359, 122);
            this.grpLista.TabIndex = 13;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Alunos Cadastrados";
            // 
            // grdDados
            // 
            this.grdDados.AllowUserToAddRows = false;
            this.grdDados.AllowUserToDeleteRows = false;
            this.grdDados.AllowUserToResizeColumns = false;
            this.grdDados.AllowUserToResizeRows = false;
            this.grdDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDados.Location = new System.Drawing.Point(6, 19);
            this.grdDados.MultiSelect = false;
            this.grdDados.Name = "grdDados";
            this.grdDados.ReadOnly = true;
            this.grdDados.RowHeadersVisible = false;
            this.grdDados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDados.Size = new System.Drawing.Size(342, 93);
            this.grdDados.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(254, 318);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 41);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(132, 318);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(114, 41);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.txtPesquisa);
            this.grpPesquisa.Controls.Add(this.lblPesquisa);
            this.grpPesquisa.Location = new System.Drawing.Point(10, 7);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(359, 53);
            this.grpPesquisa.TabIndex = 12;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Dados para Pesquisa";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(83, 22);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(265, 20);
            this.txtPesquisa.TabIndex = 0;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(6, 25);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(71, 13);
            this.lblPesquisa.TabIndex = 0;
            this.lblPesquisa.Text = "Pesquisar por";
            // 
            // grpDImc
            // 
            this.grpDImc.Controls.Add(this.lblUsuario);
            this.grpDImc.Controls.Add(this.btnCalcular);
            this.grpDImc.Controls.Add(this.txtImc);
            this.grpDImc.Controls.Add(this.lblImc);
            this.grpDImc.Controls.Add(this.lblPeso);
            this.grpDImc.Controls.Add(this.txtSenha);
            this.grpDImc.Controls.Add(this.txtPeso);
            this.grpDImc.Controls.Add(this.lblIdade);
            this.grpDImc.Controls.Add(this.lblAltura);
            this.grpDImc.Controls.Add(this.txtConfirmacao);
            this.grpDImc.Controls.Add(this.txtAltura);
            this.grpDImc.Controls.Add(this.lblAnos);
            this.grpDImc.Location = new System.Drawing.Point(9, 194);
            this.grpDImc.Name = "grpDImc";
            this.grpDImc.Size = new System.Drawing.Size(359, 118);
            this.grpDImc.TabIndex = 14;
            this.grpDImc.TabStop = false;
            this.grpDImc.Text = "Gravar IMC";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(119, 48);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 29;
            this.lblPeso.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(150, 46);
            this.txtPeso.MaxLength = 100;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(46, 20);
            this.txtPeso.TabIndex = 22;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(15, 49);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 28;
            this.lblAltura.Text = "Altura";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(55, 45);
            this.txtAltura.MaxLength = 20;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(46, 20);
            this.txtAltura.TabIndex = 21;
            // 
            // lblAnos
            // 
            this.lblAnos.AutoSize = true;
            this.lblAnos.Location = new System.Drawing.Point(285, 49);
            this.lblAnos.Name = "lblAnos";
            this.lblAnos.Size = new System.Drawing.Size(31, 13);
            this.lblAnos.TabIndex = 27;
            this.lblAnos.Text = "Anos";
            // 
            // txtConfirmacao
            // 
            this.txtConfirmacao.Location = new System.Drawing.Point(60, 19);
            this.txtConfirmacao.MaxLength = 100;
            this.txtConfirmacao.Name = "txtConfirmacao";
            this.txtConfirmacao.PasswordChar = '*';
            this.txtConfirmacao.Size = new System.Drawing.Size(256, 20);
            this.txtConfirmacao.TabIndex = 24;
            this.txtConfirmacao.UseSystemPasswordChar = true;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(209, 48);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 26;
            this.lblIdade.Text = "Idade";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(245, 45);
            this.txtSenha.MaxLength = 100;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(41, 20);
            this.txtSenha.TabIndex = 23;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.Location = new System.Drawing.Point(11, 83);
            this.lblImc.Name = "lblImc";
            this.lblImc.Size = new System.Drawing.Size(67, 13);
            this.lblImc.TabIndex = 30;
            this.lblImc.Text = "Calculo IMC ";
            // 
            // txtImc
            // 
            this.txtImc.Location = new System.Drawing.Point(84, 80);
            this.txtImc.MaxLength = 100;
            this.txtImc.Name = "txtImc";
            this.txtImc.Size = new System.Drawing.Size(65, 20);
            this.txtImc.TabIndex = 31;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(187, 77);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(114, 25);
            this.btnCalcular.TabIndex = 32;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(11, 22);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 33;
            this.lblUsuario.Text = "Usuario";
            // 
            // frmImc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 366);
            this.Controls.Add(this.grpDImc);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.grpLista);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.grpPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMC Alunos";
            this.grpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.grpDImc.ResumeLayout(false);
            this.grpDImc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.DataGridView grdDados;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.GroupBox grpDImc;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtConfirmacao;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblAnos;
        private System.Windows.Forms.Label lblImc;
        private System.Windows.Forms.TextBox txtImc;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblUsuario;
    }
}