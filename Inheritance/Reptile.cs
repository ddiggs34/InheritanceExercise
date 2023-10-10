using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public bool HasLegs { get; set; }
        public bool CanBeVenomous { get; set; }
        public bool IsColdBlooded { get; set; }
        public string Habitat {  get; set; }

    }
}
