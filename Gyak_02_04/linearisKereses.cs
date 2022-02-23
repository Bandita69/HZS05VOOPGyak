/*
4. Deklaráljon és inicializáljon egy tetszőleges
 méretű kétdimenziós int tömböt és külön
függvényben valósítsa meg a mátrix elemeinek kiírását 
és a lineáris keresés algoritmusát. A mátrix
sorainak száma: matrix.length ; oszlopainak száma : matrix[0].length.
 A keresendő elemet külön
függvényben, ellenőrzött módon olvassa be.
*/

using System;
namespace MyNamespace2
{
    public class MyClass2
    {
        public static void Main(string[] args)
        {

            int[,] parok = new int[100, 2];
            int index = 0;
            int ettol = 1;
            int eddig = 10;
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

            MyClass2 my = new MyClass2();
            my.TombKiir(parok, index);
            double magicnumber;
            magicnumber = my.readDouble();
            System.Console.WriteLine(my.TombKeresLinear(parok, Convert.ToInt32(magicnumber), index));

        }

        bool TombKeresLinear(int[,] tomb, int keresettSzam, int index)
        {

            for (int x = 0; x < index; x++)
            {

                if (keresettSzam == tomb[x, 0] || keresettSzam == tomb[x, 1])
                {
                    return true;
                }


            }
            return false;


        }

        void TombKiir(int[,] tomb, int index)
        {
            for (var i = 0; i < index; i++)

            {
                System.Console.WriteLine("{ " + tomb[i, 0] + " , " + tomb[i, 1] + " }");
            }


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