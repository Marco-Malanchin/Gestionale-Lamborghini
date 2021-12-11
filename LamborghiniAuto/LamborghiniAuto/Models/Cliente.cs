using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LamborghiniAuto.Models
{
    public class Cliente : Persona
    {
        [NotMapped]
        public List<string> acquisti { get; set; }
        public List<Auto> auto { get; set; }
        public Cliente()
        {

        }
    }
}
