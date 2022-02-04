using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LamborghiniAuto.Models
{
    public class Preventivo
    {
        [Key]
        public int id { get; set; }
        public string nomeCl { get; set; }
        public string cognomeCl { get; set; }
        public string numeroCl { get; set; }
        public Preventivo()
        {

        }
    }
}
