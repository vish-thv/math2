using System;
using static mathdll.Class1;
namespace math2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            mathdll.Class1 c = new mathdll.Class1(2, 3);
            Console.WriteLine("added:"+c.add(2,3));
            Console.WriteLine("multiply:" + c.multiply(2, 3));
            Console.ReadLine();

        }
    }
}
