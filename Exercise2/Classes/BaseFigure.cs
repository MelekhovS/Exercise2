using Exercise2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2.Classes
{
    /// <summary>
    /// Легкость добавления других фигур
    /// </summary>
    public abstract class BaseFigure : IPerimetor
    {
        public abstract double GetPerimetor();
        
    }
}
