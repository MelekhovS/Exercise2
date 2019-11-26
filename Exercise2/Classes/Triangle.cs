using Exercise2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise2.Classes
{
    public  class Triangle:BaseFigure, ISquare
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public override double GetPerimetor()
        {
            //Gerona
            var p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));

        }

        public bool ISquare()
        {
            var g = 0.0;
            var c = 0.0;
            var c2 = 0.0;
           
            var list = (from t in new []{ SideA, SideB, SideC }
                       orderby t descending
                       select t).ToList();

            g = list[0];
            c = list[1];
            c2 = list[2];

            return Math.Pow(g, 2) == Math.Pow(c , 2) + Math.Pow(c2, 2 ); 

        }
    }
}
