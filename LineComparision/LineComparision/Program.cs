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
            double length1 = line.CalculateLength();
            Console.WriteLine("Length of 1st Line : " + length1);

            Length line2 = new Length(5, 6, 7, 9);
            double length2 = line2.CalculateLength();
            Console.WriteLine("Length of 2nd Line : " + length2);

            //UC2-EqualsTo method
            if (length1.Equals(length2))
            {
                Console.WriteLine("Both Line Are Equal");
            }
            else
            {
                Console.WriteLine("Both Line Are not Equal");
            }

            //UC3-CompareTo method
            if(length1.CompareTo(length2) == 0)
            {
                Console.WriteLine("Both Line Are Equal");
            }
            else if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("1st Line is greter");
            }
            else
            {
                Console.WriteLine("2nd Line is greter");
            }

            Console.ReadLine();
        }
    }
}
