using System;

namespace ConsoleApp9
{
    class Program
    {
        static double f(double x)
        {
            try
            {
                if (Math.Abs(Math.Pow(x, 3) + 8)==0) throw new Exception();
                else return 3 / (Math.Abs(Math.Pow(x, 3)+8));
            }
            catch
            {
                throw;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                
                Console.Write("a=");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b=");
                double b = double.Parse(Console.ReadLine());
                Console.Write("h=");
                double h = double.Parse(Console.ReadLine());
                if(b<a||h<0) throw new Exception();
                for (double i = a; i <= b; i += h)
                    try
                    {
                        Console.WriteLine("y({0}) = {1:f10}", i, f(i));
                    }
                    catch
                    {
                        Console.WriteLine("y({0})=error", i);
                    }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch
            {
                Console.WriteLine("Некорректный ввод данных!");
            }
        }
    }
}