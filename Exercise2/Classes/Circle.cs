using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2.Classes
{
    public class Circle: BaseFigure
    {
        public Double Radius { get; set; }


        public override double GetPerimetor()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }
    }
}
