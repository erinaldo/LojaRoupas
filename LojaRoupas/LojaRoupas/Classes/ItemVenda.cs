﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas.Classes
{
    class ItemVenda : ItemDocumento
    {
        private Double prcVenda;
        public Double getPrcVenda(){ return this.prcVenda; }
        public void setPrcVenda(Double prcVenda){ this.prcVenda = prcVenda; }
    }
}