using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace WSTower_Midnight.Models
{
    public class Evento
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NomeEvento { get; set; }
        public string LocalEvento { get; set; }
        public string Descricao { get; set; }       
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public int NumeroDeComparecimento { get; set; }
    }
}
