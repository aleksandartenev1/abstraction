using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public abstract class Plane : IComparable<Plane>
    {
        public abstract string Type { get; }
        public abstract int Speed { get; }

        public int CompareTo(Plane other)
        {
            return this.Speed.CompareTo(other.Speed);
        }

        public override string ToString()
        {
            string theString = "This is: " + this.Type;
            return theString;
        }
    }
}