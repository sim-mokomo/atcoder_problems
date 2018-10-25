using System;

namespace ABC001
{
    class ABC001_A
    {
        private void Answer()
        {
            int preSnowHeight = int.Parse(Console.ReadLine());
            int nowSnowHeight = int.Parse(Console.ReadLine());

            int diff = preSnowHeight - nowSnowHeight;
            Console.WriteLine($"{diff}");
        }
    }
}