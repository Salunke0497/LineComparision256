using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    public class Program
    {
        static void Main(string[] args)
        {
            Length line = new Length(1, 2, 3, 4);
            line.CalculateLength();
            Console.ReadLine();
        }
    }
}
