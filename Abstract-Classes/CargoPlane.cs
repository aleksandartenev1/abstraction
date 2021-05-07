using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public class CargoPlane : JetPlane
    {
        public override string Type
        {
            get
            {
                return "CargoPlane";
            }
        }

        public override int Speed
        {
            get
            {
                return 700;
            }
        }

        public override void RunAutopilot()
        {
            Console.WriteLine($"The {this.Type} is in autopilot!");
        }
    }
}