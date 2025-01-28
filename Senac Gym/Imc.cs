﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySmile;

namespace Senac_Gym
{
    internal class Imc
    {
        //Definimos as propriedades da classe
        public int id { get; set; }
        public int idAluno { get; set; }
        public string nome { get; set; }
        public string data { get; set; }
        public int altura { get; set; }
        public int peso { get; set; }
        public int idade { get; set; }
        //Criamos o método construtor para definirmos valores
        //padrão para as propriedades no momento da instância do objeto
        public Imc()
        {
            id = 0;
            idAluno = 0;
            nome = "";
            data = "";
            altura = 0;
            peso = 0;
            idade = 0;
        }
        //Instanciamos os objetos necessários para
        //a comunicação entre o objeto criado e o banco de dados
        AcessoBD acesso = new AcessoBD();
        DataTable dt = new DataTable();
        List<SqlParameter> lista = new List<SqlParameter>();
        string sql = string.Empty;
        public DataTable Consultar()
        {
            //definimos um bloco try/catch para garantir a execução
            //do fluxo fora do nosso ambiente
            try
            {
                //Limpamos a lista de parâmetros
                lista.Clear();
                //Definimos o comando SQL (SELECT)
                sql = "select tblImc.id, alu.id, nome, altura, peso, data \n";
                sql += "from tblIMC inner join tblAluno alu on alu.id = tblIMC.idAluno \n";
                if (id != 0)
                {
                    //Caso o ID esteja preenchido
                    //Definimos a consulta pela chave primária
                    sql += "where tblImc.id = @id \n";
                    //adicionamos o parâmetro à lista de parâmetros
                    lista.Add(new SqlParameter("@id", id));
                }
                else if (nome != string.Empty)
                {
                    //Caso o nome esteja preenchido
                    //Definimos a consulta por aproximação através do nome
                    sql += "where nome like @nome \n";
                    //adicionamos o parâmetro à lista de parâmetros
                    lista.Add(new SqlParameter("@nome", "%" + nome + "%"));
                }
                //Ordenamos o retorno pelo nome do usuario
                sql += "order by nome";
                //Solicitamos ao objeto acesso a execução da consulta
                //E o resultado é armazenado no nosso DataTable (dt)
                dt = acesso.ConsultarSQL(sql, lista);

                if (dt.Rows.Count > 0 && id != 0)
                {
                    //Caso a pesquisa tenha sido feita pelo Id do usuário ou 
                    //pelo login, e tenha retornado o registro especificado
                    //Atribuímos os valores retornados a sua respectiva
                    //propriedade da classe
                    id = Convert.ToInt32(dt.Rows[0]["tblImc.id"]);
                    idAluno = Convert.ToInt32(dt.Rows[0]["alu.id"]);
                    nome = dt.Rows[0]["nome"].ToString();
                    altura = Convert.ToInt32(dt.Rows[0]["altura"]);
                    peso = Convert.ToInt32(dt.Rows[0]["peso"]);
                    data = dt.Rows[0]["data"].ToString();
                }
                //Retornamos o DataTable com os dentistas retornados na consulta
                return dt;
            }
            catch (Exception ex)
            {
                //Caso ocorra algum erro fora do ambiente
                //Enviamos o erro para quem chamou o método
                throw new Exception(ex.Message);
            }
        }
        public void Gravar()
        {
            //definimos um bloco try/catch para garantir a execução
            //do fluxo fora do nosso ambiente
            try
            {
                //Limpamos a lista de parâmetros
                lista.Clear();
                if (id == 0)
                {
                    //Caso seja um registro novo
                    //Montamos o INSERT
                    sql = "insert into tblIMC \n";
                    sql += "(idAluno, peso, altura, data)\n";
                    sql += "values \n";
                    sql += "(@idAluno, @peso, @altura, @data)";
                }
                else
                {
                    //Caso seja um registro já existente
                    //Montamos o UPDATE
                    sql = "update tblImc\n";
                    sql += "set \n";
                    sql += "idAluno     = @idAluno, \n";
                    sql += "peso     = @peso, \n";
                    sql += "altura     = @altura, \n";
                    sql += "data     = @data, \n";

                    //Adicionamos separadamente o Id 
                    lista.Add(new SqlParameter("@id", id));
                }
                //Adicionamos em conjunto o restante dos parâmetros SQL
                lista.Add(new SqlParameter("@idAluno", idAluno));
                lista.Add(new SqlParameter("@peso", peso));
                lista.Add(new SqlParameter("@altura", altura));
                lista.Add(new SqlParameter("@data", data));
                //Solicitamos ao acesso para executar o INSERT/UPDATE junto ao banco de dados
                acesso.ExecutarSQL(sql, lista);
            }
            catch (Exception ex)
            {
                //Caso ocorra algum erro fora do ambiente
                //Enviamos o erro para quem chamou o método
                throw new Exception(ex.Message);
            }
        }
    }
}

