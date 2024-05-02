using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppViagem.Models
{
    public class pedagio
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public double Valor { get; set; }
        public string Local { get; set; }
    }
}
