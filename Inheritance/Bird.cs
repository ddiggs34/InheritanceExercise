using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{   // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class
    public class Bird : Animal
    {
        public bool CanFly { get; set; }
        public int WingSpanFt { get; set; }
        public bool Migrate {  get; set; }
        public string FeatherColor { get; set; }
    }
}
