using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using AppFinanceiro.Models;

namespace AppFinanceiro.Controller
{
    public class DBFinanca
    {
        SQLiteConnection conn; //representa o banco de dados
        public string StatusMessage { get; set; } //representa a mensagem da ultima operação

        public DBFinanca(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Financa>(); //cria a tabela no banco se ela não existir
        }

        public void Inserir(Financa financa)
        {

        }

        public void Alterar(Financa financa)
        {

        }

        public void Excluir(int Id)
        {

        }

        //localizar
        //mais um montão de coisas
    }
}
