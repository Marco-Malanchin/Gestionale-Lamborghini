using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LamborghiniAuto.Models
{
    public class Dipendente : Persona
    {
        public int stipendio { get; set; }
        public string mestiere { get; set; }
        public Dipendente()
        {

        }
    }
}
