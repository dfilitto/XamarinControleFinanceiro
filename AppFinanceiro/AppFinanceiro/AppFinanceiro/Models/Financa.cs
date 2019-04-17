using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppFinanceiro.Models
{
    [Table("Financas")]
    public class Financa
    {
        
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250), Unique]
        public string Descricao { get; set; }

        [MaxLength(250), Unique]
        public string TipoOperacao { get; set; } 

        public DateTime Data { get; set; }
        public Double valor { get; set; }
    }
}
