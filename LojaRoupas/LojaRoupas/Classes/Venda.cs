﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas.Classes
{
    class Venda : Documento
    {
        private int idCliente;
        private ItemVenda[] itensVenda;
        
        public void setIdCliente(int idCliente){ this.idCliente = idCliente; }
        public void setItensVenda(ItemVenda[] itensVenda) { this.itensVenda = itensVenda; }

        public int getIdCliente() { return this.idCliente; }
        public ItemVenda[] getItensVenda(){ return this.itensVenda; }
        
        
        
    }
}
