using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LamborghiniAuto.Models
{
    public class Persona
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public string codFisc { get; set; }
        public DateTime dataNascita { get; set; }
        public Persona()
        {

        }
    }
}
