using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSRect
{

    class Rectangle
    {
        public int length;
        public int breadth;
        public Rectangle(int _length, int _breadth)
        {
            this.length = _length;
            this.breadth = _breadth;
        }
        public override string ToString()
        {
            return $"[Length={length},Breadth={breadth},Areas={FindArea()}]";
        }
        public int FindArea()
        {
            return length * breadth;
        }
        public bool IsAreaGt(Rectangle other)
        {
            return FindArea()>other.FindArea();
        }
        public bool IsAreaEq(Rectangle other)
        {
            return FindArea() == other.FindArea();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle firstLand = new Rectangle(50, 40);
            Rectangle secondLand = new Rectangle(60, 35);
            if (firstLand.IsAreaGt(secondLand))
            {
                Console.WriteLine($"first land {firstLand} is greater than second land {secondLand}");
            }
            else if (firstLand.IsAreaEq(secondLand))
            {
                Console.WriteLine($"first land {firstLand} is equal to second land {secondLand}");

            }
            else
            {
                Console.WriteLine($"first land {firstLand} is less than to second land {secondLand}");

            }
        }
    }
}
--
