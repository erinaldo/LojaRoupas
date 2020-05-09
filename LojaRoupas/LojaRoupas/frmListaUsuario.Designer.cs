﻿namespace LojaRoupas
{
    partial class frmListaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaUsuario));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lstListaUsuario = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nascimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cadastro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnCancelar.Location = new System.Drawing.Point(722, 103);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 55);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnNovo.Location = new System.Drawing.Point(722, 42);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(112, 55);
            this.btnNovo.TabIndex = 26;
            this.btnNovo.Text = "NOVO ";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lstListaUsuario
            // 
            this.lstListaUsuario.BackColor = System.Drawing.SystemColors.InfoText;
            this.lstListaUsuario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nome,
            this.cpf,
            this.email,
            this.telefone,
            this.nascimento,
            this.endereco,
            this.cadastro});
            this.lstListaUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListaUsuario.ForeColor = System.Drawing.Color.BurlyWood;
            this.lstListaUsuario.HideSelection = false;
            this.lstListaUsuario.Location = new System.Drawing.Point(0, 0);
            this.lstListaUsuario.Name = "lstListaUsuario";
            this.lstListaUsuario.Size = new System.Drawing.Size(846, 450);
            this.lstListaUsuario.TabIndex = 25;
            this.lstListaUsuario.UseCompatibleStateImageBehavior = false;
            this.lstListaUsuario.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 28;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 84;
            // 
            // cpf
            // 
            this.cpf.Text = "Cpf";
            this.cpf.Width = 102;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 131;
            // 
            // telefone
            // 
            this.telefone.Text = "Telefone";
            this.telefone.Width = 79;
            // 
            // nascimento
            // 
            this.nascimento.Text = "Nascimento";
            this.nascimento.Width = 71;
            // 
            // endereco
            // 
            this.endereco.Text = "Endereço";
            this.endereco.Width = 154;
            // 
            // cadastro
            // 
            this.cadastro.Text = "Login";
            // 
            // frmListaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lstListaUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmListaUsuario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ListView lstListaUsuario;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader cpf;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader telefone;
        private System.Windows.Forms.ColumnHeader nascimento;
        private System.Windows.Forms.ColumnHeader endereco;
        private System.Windows.Forms.ColumnHeader cadastro;
    }
}