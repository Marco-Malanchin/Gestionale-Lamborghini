using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LamborghiniAuto.Models
{
    public class Auto
    {
        public int id { get; set; }
        public string modello { get; set; }
        public double prezzo { get; set; }
        public string info { get; set; }
        public Auto()
        {

        }
    }
}
