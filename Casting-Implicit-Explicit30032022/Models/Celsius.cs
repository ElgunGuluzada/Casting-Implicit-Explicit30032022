using System;
using System.Collections.Generic;
using System.Text;

namespace Casting_Implicit_Explicit30032022.Models
{
    public class Celsius
    {
        public double Degree { get; set; }


        public Celsius(double c)
        {
            Degree = c;
        }

        public static implicit operator Kelvin(Celsius c)
        {
            return new Kelvin(c.Degree+273);
        }
    }
}
