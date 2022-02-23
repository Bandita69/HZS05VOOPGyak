using System;
namespace masodik

{
    public class MyPrime
    {
        public static void Main(string[] args)
        {
            int[,] parok = new int[100000,2];
            int index = 0;
            int ettol = 1;
            int eddig = 100;
            for (var x = ettol; x <= eddig; x++)
            {
                for (var y = ettol; y <= eddig; y++)
                {
                    if(x==y) continue;
                    parok[index,0] = x;
                    parok[index,1] = y;
                    index ++;
                }
            }
        int szamlalo =1;
        for (var i = 0; i <= index; i++)
        {
            if (EzPrimE(parok[i,1]) && EzPrimE(parok[i,0]) && parok[i,1]-parok[i,0] == 2)
            {
                System.Console.WriteLine("{0}. ikerprim:  {1}  {2}",szamlalo,parok[i,1],parok[i,0]);
                szamlalo ++;
            }
        }

        }

        public static bool EzPrimE(int szam)
        {
            if (szam <= 1) return false;
            if (szam == 2) return true;
            if (szam % 2 == 0) return false;

            var margin = (int)Math.Floor(Math.Sqrt(szam));

            for (int i = 3; i <= margin; i += 2)
                if (szam % i == 0)
                    return false;

            return true;
        }
    }
}