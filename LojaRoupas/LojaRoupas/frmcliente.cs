﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LojaRoupas.Classes;
using System.IO;


namespace LojaRoupas
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.setId(int.Parse(lblID.Text));
            cliente.setCpf(txtCPF.Text);
            cliente.setNome(txtNome.Text);
            cliente.setEmail(txtEmail.Text);
            cliente.setEndereco(txtEndereco.Text);
            cliente.setNascimento(txtNascimento.Text);
            cliente.setTelefone(txtTelefone.Text);

            try
            {
                cliente.cadCliente(cliente);
                MessageBox.Show("Forncedor Cadastrado com Sucesso!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (IOException erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
