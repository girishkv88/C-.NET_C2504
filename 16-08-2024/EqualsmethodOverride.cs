using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Array
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            var other = (Point)obj;
            return X == other.X && Y == other.Y;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point() { X = 1, Y = 2 };
            var p2 = new Point() { X = 1, Y = 2 };
            if (p1.Equals(p2))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Not same");
            }
        }
    }
}
