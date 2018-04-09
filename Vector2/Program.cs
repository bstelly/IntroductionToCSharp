using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2 testOne = new Vector2(10, 10);
            Vector2  testTwo = new Vector2(3, 5);
            Vector2 testThree = new Vector2(10, 10);
            Vector2 sum = testOne + testTwo;
            Vector2 diff = testOne - testTwo;
            Vector2 scale = testTwo * 3;
            bool compare = testOne == testThree;
            float result = Vector2.Magnitude(testTwo);

            Vector2.Print(sum);
            Vector2.Print(diff);
            Vector2.Print(scale);
            Console.WriteLine(compare);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
