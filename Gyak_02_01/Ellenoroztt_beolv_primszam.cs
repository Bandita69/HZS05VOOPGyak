/*
1. 10-től indulva írja ki az első N db relatív prím számpárt. 
N-et ellenőrzötten olvassa be; értéke 1
és 10 közé essen. 
Két szám egymáshoz képest relatív prím, 
ha legnagyobb közös osztójuk 1.
*/
using System;
namespace gyakKetto
{

    public class elsoFeladat

    {
        public static void Main(string[] args)
        {


            double a;
            elsoFeladat my = new elsoFeladat();
            a = my.readDouble1es10Kozott();
            System.Console.WriteLine("szam " + a);

            int[,] parok = new int[100000, 2];
            int index = 0;
            int ettol = 1;
            int eddig = 100;
            for (var x = ettol; x <= eddig; x++)
            {
                for (var y = ettol; y <= eddig; y++)
                {
                    if (x == y) continue;
                    parok[index, 0] = x;
                    parok[index, 1] = y;
                    index++;
                }
            }
            int szamlalo = 1;

            var i = 0;

            do
            {
                if ((my.lnko(parok[i, 0], parok[i, 1])) == 1)
                {
                    System.Console.WriteLine("Relativ prim:" + parok[i, 0] + " " + parok[i, 1]);
                    szamlalo++;
                }
                i++;

            } while (szamlalo <= a);


        }

        int lnko(int szam1, int szam2)
        {
            int maradek;

            while (szam2 != 0)
            {
                maradek = szam1 % szam2;
                szam1 = szam2;
                szam2 = maradek;
            }

            return szam1;
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

        double readDouble1es10Kozott()
        {

            double a;

            do
            {
                System.Console.WriteLine("1 es 10 kozott");
                a = readDouble();
            } while (a < 1 || a > 10);
            return a;
            

        }
    }


}