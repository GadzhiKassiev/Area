using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExample
{
    class Program
    {
        static void Main(string[] args)
        {
            float entry1 = float.Parse(Console.ReadLine());
            float entry2 = float.Parse(Console.ReadLine());
            Triangle triangle = new Triangle();
            triangle.Catheter1 = entry1;
            triangle.Catheter2 = entry2;
            Console.WriteLine(triangle.Area());
            Console.ReadLine();
        }
    }
}
