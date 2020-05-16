﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaRoupas.Model;
using LojaRoupas.Classes;

namespace LojaRoupas.Controller
{
    class CFornecedor
    {
        MFornecedor conexao = new MFornecedor();

        public int NovoId() => conexao.GetNovoId();
        public void InserirFornecedor(Fornecedor fornecedor) => conexao.InserirFornecedor(fornecedor);
        public void EditarFornecedor(Fornecedor Fornecedor) => conexao.EditarFornecedor(Fornecedor);
        public void ExcluirFornecedor(int idFornecedor) => conexao.ExcluirFornecedor(idFornecedor);
        public List<Fornecedor> ListarFornecedor() => conexao.ListarFornecedor();
        public Fornecedor GetFornecedor(int id) => conexao.getFornecedor(id);
        public String GetNomeFornecedor(int id) => conexao.getNomeFornecedor(id);
        
        public void TelaFornecedor()
        {
            frmFornecedor telaFornecedor = new frmFornecedor();
            telaFornecedor.ShowDialog();
        }
        public void TelaListaFornecedor()
        {
            frmListaFornecedor telaListaFornecedor = new frmListaFornecedor();
            telaListaFornecedor.ShowDialog();
        }
    }
}