using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LamborghiniAuto.Models
{
    public class Modello : Auto
    {
        public int pezziVenduti { get; set; }
        public int pezziNoleggiati { get; set; }
        public int pezziDisponibili { get; set; }
        public Modello()
        {
            
        }
    }
}
