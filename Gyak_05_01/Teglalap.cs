/* 1. Készítsen egy Téglalap osztályt két adattaggal az oldalak egységnyi tárolásához (egészek).
 Írjon konstruktort, amely két paraméterként kapott értékkel inicializál.
 Írjon konstruktort, amely egy paraméterként kapott értékkel inicializálja mindkét adattagot
(négyzet).
 Írjon metódust, amely visszaadja a területet.
 Írjon metódust, amely egy string-be összefűzve adja vissza a téglalap adatait a következő
alakban: "a oldal, b oldal: terület".
 Írjon setter metódust, amely beállítja a téglalap oldalait a paraméterként kapott két értékkel.
 Írjon setter metódust, amely beállítja a téglalap (négyzet) oldalait a paraméterként kapott
egyetlen értéket adva mindkét oldalnak.
 Írjon metódust, amely igazat ad, ha a téglalap nagyobb területű, mint a paraméterként kapott
téglalap, hamisat ad, ha nem.
 Írjon metódust, amely igazat ad, ha a téglalap oldalai megegyeznek a paraméterként kapott
téglalap oldalaival, hamisat ad, ha nem.

 */
using System;

namespace otodikGyak
{
    public class Téglalap
    {
        private int a;
        private int b;
        public Téglalap(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public Téglalap(int a)
        {
            this.a = a;
            this.b = a;
        }
        //PROPERTYBŐL LEHET CONSTRUKTORT GENERÁLNI
        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }






        public void setA2(int a)
        {
            this.a = a;
            this.b = a;
        }

        public void setAB(int a, int b)
        {

            this.a = a;
            this.b = b;
        }

        public int getTerület()
        {
            return a * b;

        }

        /* 
               
         Írjon metódust, amely igazat ad, ha a téglalap oldalai megegyeznek a paraméterként kapott
        téglalap oldalaival, hamisat ad, ha nem. */

        public bool nagyobbE(int a, int b)
        {
            if ((a * b) < getTerület())
            {
                return true;
            }
            return false;

        }

        public bool egyenloeE(int a, int b)
        {
            if (a == this.a && b == this.b)
            {
                return true;
            }
            return false;

        }





        public override String ToString() { return "Teglalap :" + a + " a oldal " + b + " b oldal " + getTerület() + " terulet"; }

    }


    /*     Készítsen egy futtatható osztályt, amely a Téglalap osztályt használja.
     Hozzon létre két téglalap objektumot ("a" és "b"), és deklaráljon egy harmadik referencia
    változót ("c"), amely értékül "a"-t veszi fel.
     Írja ki mindhárom referencia változó esetén a string-be összefűzött adatokat.
     Változtassa meg "a" oldalait és írja ki újra mindhárom referencia adatait.
     Változtassa meg "a" oldalait úgy, hogy az megegyezzen "b" oldalaival. Írja ki az (a == b) és
    az (a == c) kifejezések értékét. Ezután "a" és "b" összehasonlítására használja az utoljára
    definiált metódust - amely igazat ad, ha a téglalap oldalai megegyeznek a paraméterként
    kapott téglalap oldalaival, hamisat ha nem. */



    public class MyClass
    {
        public static void Main(string[] args)
        {
            Téglalap a = new Téglalap(2, 3);
            Téglalap b = new Téglalap(4, 5);


            Téglalap c = a;

            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(c);

            a.setAB(4, 5);
            System.Console.WriteLine(a == b);
            System.Console.WriteLine(a == c);
            System.Console.WriteLine(a.egyenloeE(b.A, b.B));
            /* 
                        2. Készítsen egy futtatható osztályt, amelyben létrehoz 10 darab Téglalap típusú objektumot és
            eltárolja a referenciájukat egy tömbben, véletlenszerűen generálva az oldalaikat a 2-10
            tartományban.
             Írja ki az összes téglalap adatait string-be összefűzve.
             Írja ki a legkisebb területű téglalap adatait.

             Hozzon létre egy új téglalapot, amelynek az adatait beolvassa. Számolja meg az ettől
            nagyobb területű téglalapokat.
             Írja ki az első olyan téglalapnak az indexét, amelynek az oldalai megegyeznek a beolvasott
            téglalapéval, vagy ha nincs ilyen, akkor azt hogy "nincs egyező". */



            int n = 10;
            int legkisebb = 20;
            Téglalap[] tomb = new Téglalap[n];
            Random rnd = new Random();

            for (var i = 0; i < n; i++)
            {
                tomb[i] = new Téglalap(rnd.Next(2, 10), rnd.Next(2, 10));
                System.Console.WriteLine(tomb[i]);
                if (tomb[i].getTerület() < legkisebb)
                {
                    legkisebb = i;

                }
            }
            System.Console.WriteLine(tomb[legkisebb]);


            Téglalap ujtegla;
            MyClass my = new MyClass();
            int ujA = my.readInt2es10Kozott();
            int ujB = my.readInt2es10Kozott();
            ujtegla = new Téglalap(ujA, ujB);
            int ujTerulet = ujtegla.getTerület();
            int nagyobbCount = 0;
            bool csakAzElso = true;

            for (var i = 0; i < n; i++)
            {
                if (tomb[i].getTerület() > ujTerulet)
                {
                    nagyobbCount++;

                }

                if (tomb[i].egyenloeE(ujA, ujB) && csakAzElso)
                {
                    System.Console.WriteLine("az index " + i);
                    csakAzElso = false;

                }

            }
            if (csakAzElso)
            {
                System.Console.WriteLine("nincs egyezo");
            }


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

        int readInt2es10Kozott()
        {

            int a;

            do
            {
                System.Console.WriteLine("2 es 10 kozott");
                a = readInt();
            } while (a < 2 || a > 10);
            return a;


        }


    }

}
