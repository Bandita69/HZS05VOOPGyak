using System;
using System.Text.RegularExpressions;
/* 
3. Készítsen egy Hanglemez osztályt, melynek adattagjai az előadó, a cím és a hossz (egész).
 Írjon konstruktort, amely a paraméterként kapott értékekkel inicializálja az adattagokat. */

namespace otodikGyakHanglemez
{

    public class Hanglemez
    {

        string előadó;
        string cím;
        int hossz;

        public Hanglemez(){}
        public Hanglemez(string előadó, string cím, int hossz)
        {
            Előadó = előadó;
            Cím = cím;
            Hossz = hossz;
        }

        public string Előadó { get => előadó; set => előadó = value; }
        public string Cím { get => cím; set => cím = value; }
        public int Hossz { get => hossz; set => hossz = value; }

        /* 
                Írjon metódust, amely egy string-ben összefűzve adja vissza a lemez adatait a következő
        alakban "Előadó: Cím, hossz perc". */

        public override String ToString() { return előadó + ": " + cím + ", " + hossz + " perc"; }

        /*         Írjon metódust, amely 1-t ad vissza, ha a lemez hosszabb, mint a paraméterként kapott
        lemez, -1-et ad vissza, ha a paraméterként kapott a hosszabb és 0-t ad, ha egyforma
        hosszúak.
       */

        public int HosszabbE(Hanglemez hang)
        {

            if (hang.Hossz < hossz)
            {
                return 1;

            }
            if (hang.Hossz > hossz)
            {
                return -1;

            }
            else
            {
                return 0;
            }


        }
        /* 
                 Írjon metódust, amely paraméterként egy előadót kap (string) és igazat ad, ha a lemeznek ő
        az előadója. A string-ek tartalmi egyezőségének vizsgálatára használja a string osztály
        Equals(artist) vagy Equals(artist, StringComparison.OrdinalIgnoreCase) metódusát. */

        public bool ezAzEloado(string nev)
        {
            if (Előadó.Equals(nev, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            return false;


        }





    }

    /* 
    Készítsen egy futtatható osztályt, amelyben létrehoz és tömbben tárol beolvasott számú beolvasott
    adatú hanglemezt. Írja ki a leghosszabb lemez adatait. Írja ki egy beolvasott nevű előadó lemezeit.  */
    public class MyClass
    {
        public static void Main(string[] args)
        {
            MyClass my = new MyClass();
            int n = my.readInt();
            Hanglemez[] tomb = new Hanglemez[n];

            for (var i = 0; i < n; i++)

            {
                Hanglemez tomb[i] = new Hanglemez();
                
            }
            int leghosszabb = 0;
            

            for (var i = 0; i < n; i++)
            {
                
                
                tomb[i].Előadó = my.readValidNames();
                tomb[i].Cím = my.readValidNames();
                tomb[i].Hossz = my.readInt();

                System.Console.WriteLine("ezt ertettem" + tomb[i]);
            }
            int x;
            for (x = 0; x < n; x++)
            {
                if (tomb[x].Hossz > leghosszabb)
                {
                    leghosszabb = tomb[x].Hossz;

                }


            }
            System.Console.WriteLine(tomb[x]);

        }


        string readValidNames()
        {
            string nam = "";
            Console.WriteLine("Adj meg egy nevet");
        FIXME: // itt van valami hiba , de mukodik
            while (!nameCheck(nam = Console.ReadLine()))
            {
                Console.WriteLine("Nem jo nev, probald ujra");
            }
            return nam;



        }
        bool nameCheck(string nam)
        {

            var name = nam.Trim();
            if (!Regex.IsMatch(name, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                return false;
            }
            else { return true; }


        }


        int readInt()
        {
            int a;
            Console.WriteLine("Adj meg egy szamot");
            while
            (!(int.TryParse(Console.ReadLine(), out a)))
            {

                Console.WriteLine("Nem szam, probald ujra");



            }
            return a;



        }

    }

}