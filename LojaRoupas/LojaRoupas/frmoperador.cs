﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LojaRoupas.Classes;

namespace LojaRoupas
{
    public partial class frmOperador : Form
    {
        
        Operador operador = new Operador();
        public frmOperador()
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            operador.setId(int.Parse(lblID.Text));
            operador.setCpf(txtCPF.Text);
            operador.setNome(txtNome.Text);
            operador.setEmail(txtEmail.Text);
            operador.setEndereco(txtEndereco.Text);
            operador.setNascimento(txtNascimento.Text);
            operador.setTelefone(txtTelefone.Text);
            operador.setTurno(txtTurno.Text);
            try
            {
                operador.cadOperador(operador);
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

        private void frmOperador_Load(object sender, EventArgs e)
        {
            lblID.Text = Convert.ToString(operador.NovoId());
          
        }
    }
}
