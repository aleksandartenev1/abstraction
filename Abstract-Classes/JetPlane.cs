using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public abstract class JetPlane : Plane
    {
        public int Engines { get; set; }

        public virtual void RunAutopilot()
        {
            Console.WriteLine($"The {this.Type} is in autopilot!");
        }
    }
}
}