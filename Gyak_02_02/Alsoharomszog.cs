using System;
namespace MyNamespace
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            double magicnumber;
            MyClass my = new MyClass();
            magicnumber = my.readDouble1es9Kozott();
            System.Console.WriteLine();
            my.alsoHaromszog(magicnumber);

        }


        void alsoHaromszog(double n)
        {

            for (var i = 1; i <= n; i++)
            {
                for (var x = 1; x <= i; x++)
                {
                    Console.Write(i+" ");

                }
                System.Console.WriteLine();

            }

        }

        double readDouble1es9Kozott()
        {

            double a;

            do
            {
                System.Console.WriteLine("1 es 10 kozott");
                a = readDouble();
            } while (a < 1 || a > 9);
            return a;

        }


        double readDouble()
        {
            double a;
            Console.WriteLine("Adj meg egy szamot");
            while
            (!(double.TryParse(Console.ReadLine(), out a)))
            {

                Console.WriteLine("Nem szam, probald ujra");



            }
            return a;



        }

    }


}