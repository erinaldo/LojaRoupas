﻿using System.Collections.Generic;
using Npgsql;
using LojaRoupas.Classes;
using LojaRoupas.Controller;

namespace LojaRoupas.Model
{
    class MVenda : Conexao
    {
        public override int GetNovoId()
        {
            int ultimoid = 0;
            this.Conect();
            sql = "SELECT (case when max(id) is null then 0 else max(id) end) as novoitem FROM tbvenda";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                ultimoid = rdr.GetInt32(0);
            }
            this.Desconect();
            return ultimoid + 1;
        }
        public void InserirVenda(Venda v)
        {
            this.Conect();

            sql = "INSERT INTO tbvenda(data, vlrtotal, desconto, qtditens, idcliente, idoperador)";
            sql = sql + "VALUES(@data, @vlrtotal, @desconto, @qtditens, @idcliente, @idoperador); ";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("data", v.getData());
            cmd.Parameters.AddWithValue("vlrtotal", v.getVlrTotal());
            cmd.Parameters.AddWithValue("desconto", v.getDesconto());
            cmd.Parameters.AddWithValue("qtditens", v.getQtdItens());
            cmd.Parameters.AddWithValue("idcliente", v.getIdCliente());
            cmd.Parameters.AddWithValue("idoperador", v.getIdOperador());
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.Desconect();
        }
        public List<Venda> ListarVenda()
        {
            List<Venda> Lista = new List<Venda>();
            this.Conect();
            sql = "SELECT id, data, vlrtotal, desconto, qtditens, idcliente, idoperador FROM tbvenda  order by id;";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Venda v = new Venda();
                CItemVenda i = new CItemVenda();
                List<ItemVenda> itensVenda = new List<ItemVenda>();
                v.setID(rdr.GetInt32(0));
                v.setData(rdr.GetString(1));
                v.setVlrTotal(rdr.GetDouble(2));
                v.setDesconto(rdr.GetDouble(3));
                v.setQtdItens(rdr.GetInt32(4));
                v.setIdCliente(rdr.GetInt32(5));
                v.setIdOperador(rdr.GetInt32(6));
                itensVenda = i.ListarItemVenda(v.getId());
                v.setItensVenda(itensVenda);
                Lista.Add(v);
            }
            this.Desconect();
            return Lista;
        }
        public int QtdVendaCliente(int idCliente)
        {
            int qtdVendas = 0;
            this.Conect();
            sql = "SELECT count(*) as total FROM tbvenda WHERE idcliente = @idCliente";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("idCliente", idCliente);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                qtdVendas = rdr.GetInt32(0);
            }
            this.Desconect();
            return qtdVendas;
        }
        public int QtdVendaOperador(int idOperador)
        {
            int qtdVendas = 0;
            this.Conect();
            sql = "SELECT count(*) as total FROM tbvenda WHERE idoperador = @idOperador";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("idOperador", idOperador);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                qtdVendas = rdr.GetInt32(0);
            }
            this.Desconect();
            return qtdVendas;
        }
    }
}