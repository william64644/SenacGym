namespace Senac_Gym
{
    partial class frmTreino
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.txtTipoCliente = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.grpCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Location = new System.Drawing.Point(36, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 266);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.txtTipoCliente);
            this.grpCliente.Controls.Add(this.lblCelular);
            this.grpCliente.Controls.Add(this.txtCelular);
            this.grpCliente.Controls.Add(this.lblTipoCliente);
            this.grpCliente.Controls.Add(this.lblCPF);
            this.grpCliente.Controls.Add(this.txtCPF);
            this.grpCliente.Controls.Add(this.label5);
            this.grpCliente.Controls.Add(this.txtNome);
            this.grpCliente.Location = new System.Drawing.Point(36, 12);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(360, 105);
            this.grpCliente.TabIndex = 4;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Paciente";
            // 
            // txtTipoCliente
            // 
            this.txtTipoCliente.Location = new System.Drawing.Point(91, 72);
            this.txtTipoCliente.MaxLength = 100;
            this.txtTipoCliente.Name = "txtTipoCliente";
            this.txtTipoCliente.ReadOnly = true;
            this.txtTipoCliente.Size = new System.Drawing.Size(257, 20);
            this.txtTipoCliente.TabIndex = 3;
            this.txtTipoCliente.TabStop = false;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(169, 49);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 25;
            this.lblCelular.Text = "Celular";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(214, 47);
            this.txtCelular.MaxLength = 100;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.ReadOnly = true;
            this.txtCelular.Size = new System.Drawing.Size(134, 20);
            this.txtCelular.TabIndex = 2;
            this.txtCelular.TabStop = false;
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(10, 76);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(78, 13);
            this.lblTipoCliente.TabIndex = 21;
            this.lblTipoCliente.Text = "Tipo de Cliente";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(10, 49);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 22;
            this.lblCPF.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(55, 47);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(113, 20);
            this.txtCPF.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(55, 21);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(293, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(416, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 97);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(13, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(147, 19);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(289, 19);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 3;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(433, 19);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmTreino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.groupBox2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTreino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Treino";
            this.groupBox2.ResumeLayout(false);
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.TextBox txtTipoCliente;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}