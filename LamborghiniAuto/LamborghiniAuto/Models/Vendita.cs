using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LamborghiniAuto.Models
{
    public class Vendita
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public DateTime dataVendita { get; set; }
        public int idMacchina { get; set; }
        public Vendita()
        {

        }
    }
}
