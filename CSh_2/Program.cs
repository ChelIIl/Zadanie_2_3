using System;

namespace CSh_2
{
    class Program
    {
        static void Main()
        {
            try
            {
                int A, B, x, y, i = 0;

                Console.WriteLine("Введите диапазон от А до В");

                Console.Write("A:");
                A = Convert.ToInt32(Console.ReadLine());

                Console.Write("B:");
                B = Convert.ToInt32(Console.ReadLine());

                if (A > B)
                {
                    Console.WriteLine("А должно быть меньше В!");
                    return;
                }

                Console.WriteLine("Какие числа выводить?");

                Console.Write("X =");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Y =");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("while:");

                i = A;

                while(i <= B)
                {
                    if (i % 10 == x || i % 10 == y)
                        Console.Write(i + " ");
                    i++;
                }

                Console.WriteLine("\n" + "do while:");

                i = A;

                do
                {
                    if (i % 10 == x || i % 10 == y)
                        Console.Write(i + " ");
                    i++;
                }

                while (i <= B);


                Console.WriteLine("\n" + "for:");

                for(int j = A; j <= B; j++)
                {
                    if (j % 10 == x || j % 10 == y)
                        Console.Write(j + " ");
                }

                Console.ReadKey();
            }

            catch
            {
                Console.WriteLine("Некоректный ввод данных!");
                Console.ReadKey();
            }
        }
    }
}
