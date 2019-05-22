using System;

namespace HomeWork_Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int discount0 = 0;
            const int discount3 = 3;
            const int discount5 = 5;
            const int discount7 = 7;
            ushort total = 1233;
            if (total >= 500)
            {
                Console.WriteLine(discount7);
            }
            else if (total >= 400)
            {
                Console.WriteLine(discount5);
            }
            else if (total >= 300 )
            {
                Console.WriteLine(discount3);
            }
            else if(total >= 0)
            {
                Console.WriteLine(discount0);
            } 
        }
    }
}
