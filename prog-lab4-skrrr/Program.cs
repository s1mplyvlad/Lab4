using System;

namespace prog_lab4_skrrr
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            Console.WriteLine("Введите первую строку : ");
            s1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку : ");
            s2 = Console.ReadLine();
            Console.WriteLine(String.Compare("a", "b"));
            int b = String.Compare(s1, s2);
            if (b == 0)
            {
                Console.WriteLine("Строки совпадают");
            }

            else { Console.WriteLine("Строки не совпадают"); }
        }

    }
}
