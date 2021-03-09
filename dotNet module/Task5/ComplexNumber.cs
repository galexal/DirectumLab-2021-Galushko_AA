using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class ComplexNumber : IComparable
    {
        public double Real { get; set; }

        public double Imaginary { get; set; }

        public double Magnitude => Math.Sqrt((this.Real * this.Real) 
            + (this.Imaginary * this.Imaginary));

        public int CompareTo(object o)
        {
            ComplexNumber cn = o as ComplexNumber;
            if (cn != null) 
                return this.Magnitude.CompareTo(cn.Magnitude);
            else 
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}
