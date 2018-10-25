using System;
using System.Linq;

namespace ABC001
{
    class Tutorial
    {
        static void Main(string[] args)
        {
            
            int a = int.Parse(Console.ReadLine());
            var array = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            string str = Console.ReadLine();

            Console.Out.WriteLine($"{a + array[0] + array[1] } {str}");
            
        }
    }
}