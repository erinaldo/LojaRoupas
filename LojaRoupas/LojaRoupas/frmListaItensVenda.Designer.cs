﻿namespace LojaRoupas
{
    partial class frmListaItensVenda
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
            this.lstListaProduto = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codigoBarras = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.corProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tamProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precoCusto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precoVenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtdEstProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstListaProduto
            // 
            this.lstListaProduto.BackColor = System.Drawing.Color.Black;
            this.lstListaProduto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.codigoBarras,
            this.descricao,
            this.corProduto,
            this.tamProduto,
            this.precoCusto,
            this.precoVenda,
            this.qtdEstProduto});
            this.lstListaProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListaProduto.ForeColor = System.Drawing.Color.BurlyWood;
            this.lstListaProduto.HideSelection = false;
            this.lstListaProduto.Location = new System.Drawing.Point(0, 0);
            this.lstListaProduto.Name = "lstListaProduto";
            this.lstListaProduto.Size = new System.Drawing.Size(635, 450);
            this.lstListaProduto.TabIndex = 1;
            this.lstListaProduto.UseCompatibleStateImageBehavior = false;
            this.lstListaProduto.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 30;
            // 
            // codigoBarras
            // 
            this.codigoBarras.Text = "Codigo Barras";
            this.codigoBarras.Width = 103;
            // 
            // descricao
            // 
            this.descricao.Text = "Descrição";
            this.descricao.Width = 146;
            // 
            // corProduto
            // 
            this.corProduto.Text = "Cor";
            this.corProduto.Width = 84;
            // 
            // tamProduto
            // 
            this.tamProduto.Text = "Tamanho";
            // 
            // precoCusto
            // 
            this.precoCusto.Text = "Custo";
            this.precoCusto.Width = 70;
            // 
            // precoVenda
            // 
            this.precoVenda.Text = "Venda";
            this.precoVenda.Width = 77;
            // 
            // qtdEstProduto
            // 
            this.qtdEstProduto.Text = "Estoque";
            // 
            // frmListaItensVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.lstListaProduto);
            this.Name = "frmListaItensVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Itens da Venda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstListaProduto;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader codigoBarras;
        private System.Windows.Forms.ColumnHeader descricao;
        private System.Windows.Forms.ColumnHeader corProduto;
        private System.Windows.Forms.ColumnHeader tamProduto;
        private System.Windows.Forms.ColumnHeader precoCusto;
        private System.Windows.Forms.ColumnHeader precoVenda;
        private System.Windows.Forms.ColumnHeader qtdEstProduto;
    }
}