﻿using System;
using System.Collections.Generic;
using Npgsql;
using LojaRoupas.Classes;

namespace LojaRoupas.Model
{
    class MProduto : Conexao
    {
        public override int GetNovoId()
        {
            int ultimoid = 0;
            this.Conect();
            sql = "SELECT (case when max(id) is null then 0 else max(id) end) as novoitem FROM tbproduto";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //Console.WriteLine("{0}", rdr.GetInt32(0));
                ultimoid = rdr.GetInt32(0);
            }
            this.Desconect();
            return ultimoid + 1;
        }
        public void InserirProduto(Produto produto)
        {
            this.Conect();

            sql = "INSERT INTO tbproduto(codigobarras, descricao, cor, tamanho, precocusto, precovenda, qtdestoque) ";
            sql = sql + "VALUES(@codigoBarras, @descricao, @cor, @tamanho, @precoCusto, @precoVenda, @qtdEstoque); ";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("codigoBarras", produto.getCodigoBarras());
            cmd.Parameters.AddWithValue("descricao", produto.getDescProduto());
            cmd.Parameters.AddWithValue("cor", produto.getCorProduto());
            cmd.Parameters.AddWithValue("tamanho", produto.getTamProduto());
            cmd.Parameters.AddWithValue("precoCusto", produto.getPrecoCusto());
            cmd.Parameters.AddWithValue("precoVenda", produto.getPrecoVenda());
            cmd.Parameters.AddWithValue("qtdEstoque", produto.getQtdEstProduto());
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.Desconect();
            //Console.WriteLine("row inserted");
        }
        public void EditarProduto(Produto produto)
        {
            this.Conect();

            sql = "UPDATE tbproduto SET codigobarras=@codigobarras, descricao=@descricao, cor=@cor," +
                " tamanho=@tamanho, precocusto=@precocusto, precovenda=@precovenda WHERE id=@id; ";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", produto.getIdProduto());
            cmd.Parameters.AddWithValue("codigoBarras", produto.getCodigoBarras());
            cmd.Parameters.AddWithValue("descricao", produto.getDescProduto());
            cmd.Parameters.AddWithValue("cor", produto.getCorProduto());
            cmd.Parameters.AddWithValue("tamanho", produto.getTamProduto());
            cmd.Parameters.AddWithValue("precoCusto", produto.getPrecoCusto());
            cmd.Parameters.AddWithValue("precoVenda", produto.getPrecoVenda());
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.Desconect();
        }
        public List<Produto> ListarProduto()
        {
            List<Produto> Lista = new List<Produto>();
            this.Conect();
            sql = "SELECT  id, codigobarras, descricao, cor, tamanho, precocusto, precovenda, qtdestoque " +
                "FROM tbproduto order by id";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //Console.WriteLine("{0}", rdr.GetInt32(0));
                Produto produto = new Produto();
                produto.setIdProduto(rdr.GetInt32(0));
                produto.setCodigoBarras(rdr.GetString(1));
                produto.setDescProduto(rdr.GetString(2));
                produto.setCorProduto(rdr.GetString(3));
                produto.setTamProduto(rdr.GetString(4));
                produto.setPrecoCusto(rdr.GetDouble(5));
                produto.setPrecoVenda(rdr.GetDouble(6));
                produto.setQtdEstProduto(rdr.GetInt32(7));
                Lista.Add(produto);
            }
            this.Desconect();
            return Lista;
        }
        public List<Produto> ListarProduto(String codigobarras, String descricao, String cor, String tamanho, Double precocusto, Double precovenda)
        {
            List<Produto> Lista = new List<Produto>();
            this.Conect();
            sql = "SELECT  id, codigobarras, descricao, cor, tamanho, precocusto, precovenda, qtdestoque " +
                " FROM tbproduto " +
                " WHERE  codigobarras like @codigobarras and descricao like @descricao " +
                " and cor like @cor and tamanho like @tamanho ";
            if (precocusto != 0) sql = sql + " and precocusto = @precocusto ";
            if (precovenda != 0) sql = sql + " and precovenda = @precovenda ";
            sql = sql + " order by id";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("codigobarras", "%"+codigobarras+ "%");
            cmd.Parameters.AddWithValue("descricao", "%" + descricao + "%");
            cmd.Parameters.AddWithValue("cor", "%" + cor + "%");
            cmd.Parameters.AddWithValue("tamanho", "%" + tamanho + "%");
            if (precocusto != 0) cmd.Parameters.AddWithValue("precocusto", precocusto);
            if (precovenda != 0) cmd.Parameters.AddWithValue("precovenda", precovenda);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //Console.WriteLine("{0}", rdr.GetInt32(0));
                Produto produto = new Produto();
                produto.setIdProduto(rdr.GetInt32(0));
                produto.setCodigoBarras(rdr.GetString(1));
                produto.setDescProduto(rdr.GetString(2));
                produto.setCorProduto(rdr.GetString(3));
                produto.setTamProduto(rdr.GetString(4));
                produto.setPrecoCusto(rdr.GetDouble(5));
                produto.setPrecoVenda(rdr.GetDouble(6));
                produto.setQtdEstProduto(rdr.GetInt32(7));
                Lista.Add(produto);
            }
            this.Desconect();
            return Lista;
        }
        public Produto getProduto(String codigobarras)
        {
            this.Conect();
            Produto produto = new Produto();
            sql = "SELECT  id, codigobarras, descricao, cor, tamanho, precocusto, precovenda, qtdestoque FROM tbproduto where codigobarras = @codigobarras";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("codigobarras", codigobarras);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //Console.WriteLine("{0}", rdr.GetInt32(0));                
                produto.setIdProduto(rdr.GetInt32(0));
                produto.setCodigoBarras(rdr.GetString(1));
                produto.setDescProduto(rdr.GetString(2));
                produto.setCorProduto(rdr.GetString(3));
                produto.setTamProduto(rdr.GetString(4));
                produto.setPrecoCusto(rdr.GetDouble(5));
                produto.setPrecoVenda(rdr.GetDouble(6));
                produto.setQtdEstProduto(rdr.GetInt32(7));
            }
            this.Desconect();
            return produto;
        }
        public Produto getProduto(int idProduto)
        {
            this.Conect();
            Produto produto = new Produto();
            sql = "SELECT  id, codigobarras, descricao, cor, tamanho, precocusto, precovenda, qtdestoque FROM tbproduto where id = @id";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idProduto);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //Console.WriteLine("{0}", rdr.GetInt32(0));
                produto.setIdProduto(rdr.GetInt32(0));
                produto.setCodigoBarras(rdr.GetString(1));
                produto.setDescProduto(rdr.GetString(2));
                produto.setCorProduto(rdr.GetString(3));
                produto.setTamProduto(rdr.GetString(4));
                produto.setPrecoCusto(rdr.GetDouble(5));
                produto.setPrecoVenda(rdr.GetDouble(6));
                produto.setQtdEstProduto(rdr.GetInt32(7));
            }
            this.Desconect();
            return produto;
        }
        public String getDescProduto(int idProduto)
        {
            this.Conect();
            Produto produto = new Produto();
            sql = "SELECT  id, codigobarras, descricao, cor, tamanho, precocusto, precovenda, qtdestoque FROM tbproduto where id = @id";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idProduto);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //Console.WriteLine("{0}", rdr.GetInt32(0));
                produto.setIdProduto(rdr.GetInt32(0));
                produto.setCodigoBarras(rdr.GetString(1));
                produto.setDescProduto(rdr.GetString(2));
                produto.setCorProduto(rdr.GetString(3));
                produto.setTamProduto(rdr.GetString(4));
                produto.setPrecoCusto(rdr.GetDouble(5));
                produto.setPrecoVenda(rdr.GetDouble(6));
                produto.setQtdEstProduto(rdr.GetInt32(7));
            }
            this.Desconect();
            return produto.getDescProduto() + " " + produto.getCorProduto() + " " + produto.getTamProduto();
        }
        public void SaidaEstoqueProduto(int qtdvendida, int id)
        {
            this.Conect();

            sql = "UPDATE tbproduto SET qtdestoque = qtdestoque - @qtdvendida WHERE id = @id;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("qtdvendida", qtdvendida);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.Desconect();
            //Console.WriteLine("row updated");
        }
        public void EntradaEstoqueProduto(int qtdcomprada, int id)
        {
            this.Conect();

            sql = "UPDATE tbproduto SET qtdestoque = qtdestoque + @qtdcomprada WHERE id = @id;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("qtdcomprada", qtdcomprada);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.Desconect();
            //Console.WriteLine("row updated");
        }
    }
}