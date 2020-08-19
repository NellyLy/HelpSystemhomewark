using System;

namespace calkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double x, y;
                string c;
                Console.WriteLine("x=");
                x = double.Parse(Console.ReadLine());

                Console.WriteLine("y=");
                y = double.Parse(Console.ReadLine());

                Console.WriteLine("+,-,*,/");
                c = Console.ReadLine();

                if (c == "+")
                {
                    Console.WriteLine(x + y);
                }
                else if (c == "-")
                {
                    Console.WriteLine(x - y);
                }
                else if (c == "*")
                {
                    Console.WriteLine(x * y);
                }
                else if (c == "/")
                {
                    if (y == 0)
                    {
                        Console.WriteLine("you can't always get what you whant");
                    }
                    else
                    {
                        Console.WriteLine(x / y);
                    }

                }
                else
                {
                    Console.WriteLine("try again with '+',-','*','/'");
                }


                Console.ReadLine();
            }
        }
    }
}
