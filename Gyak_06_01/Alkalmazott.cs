using System;
using System.Text.RegularExpressions;

/* 
1. a) Készítsen egy Alkalmazott osztályt saját névtérben, név, kor és fizetés adatokkal.
 Legyen egy osztályszintű adattagja a nyugdíjkorhatár tárolására, értéke kezdetben legyen 65.
Figyelem! A static adattag kezelése csak static metódusban történhet.
 Legyen 2 konstruktora. Az egyik a paraméterként kapott név, kor és fizetés értékekkel
inicializálja az adattagokat. A másiknak csak a nevet és a kort kell megadni, a fizetés
10000*kor. A második konstruktor használja fel az elsőt.
 Legyen metódusa, amely visszaadja, hogy hány éve van még nyugdíjig */

namespace AlkalmazottName
{
    public class Alkalmazott
    {
        string név;
        DateTime birthday;
        int fizetés;
        int kor;



        static int nyugdíjkorhatár = 65;

        public Alkalmazott(string név, DateTime birthday, int fizetés)

        {
            DateTime currentDate = DateTime.Now;
            int currentYear = currentDate.Year;
            this.név = név;
            this.fizetés = fizetés;
            this.birthday = birthday;
            this.kor = currentYear - birthday.Year;

        }



        /*         Függvénytúlterhelés: a konstruktorból két változatot készítsen. Az egyik változat az alkalmazott
        nevét és 3 int paramétert kapjon (év, hónap, nap); míg a másik az alkalmazott nevét, egy int, egy
        sztring és még egy int paraméter felhasználásával adjon értéket a név és a születésnap adattagnak. A
        fizetést a 10000*kor képlettel számítsa mindkét konstruktorban.
         */


        public Alkalmazott(string név, int év, int hónap, int nap)
        {
            this.név = név;
            this.birthday = new DateTime(év, hónap, nap);
            this.fizetés = kor * 10000;

        }
        public enum honapok
        {

            január,
            február,
            március,
            április,
            május,
            június,
            július,
            augusztus,
            szeptember,
            október,
            november,
            december
            
        }

        public Alkalmazott(string név, int év, string hónap, int nap)
        {

            this.név = név;
            this.birthday = new DateTime(év,(Enum.Parse(typeof(honapok),hónap)).ToString(),nap);
            this.fizetés = kor * 10000;
        }



        public int HányÉvedVanHátra()
        {

            return nyugdíjkorhatár - kor;

        }
        /* 
                 Legyen metódusa, amely sztringbe összefűzve adja vissza az Alkalmazott adatait,
        hozzáfűzve a nyugdíjig hátralevő éveinek számát is (ToString() felüldefiniálása).
         Legyen metódusa, amely a paraméterként kapott két Alkalmazott közül azt adja vissza,
        amelyiknek több éve van még hátra a nyugdíjig.
         Legyen metódusa, amely a paraméterként kapott értékre állítja be a nyugdíjkorhatárt. */


        public override String ToString() { return "Alkalmazott :" + név + " " + kor + " " + fizetés + " " + HányÉvedVanHátra(); }

        public Alkalmazott NekiTöbbVanMégHátra(Alkalmazott egyik, Alkalmazott másik)
        {

            if (egyik.HányÉvedVanHátra() >= másik.HányÉvedVanHátra())
            {
                return egyik;
            }
            else { return másik; }

        }

        public static void NyugdíjkorhatárVáltoztatás(int ennyire)
        {
            nyugdíjkorhatár = ennyire;

        }

        /* 
        Készítsen egy futtatható osztályt ugyanebben a névtérben, amely beolvas n számú alkalmazottat egy
        tömbbe.
         Írja ki az alkalmazottak adatait, majd módosítsa a nyugdíjkorhatárt és újra írja ki az
        alkalmazottak adatait.
*/




    }
    public class AlkMain
    {
        public static void Main(string[] args)
        {

            int n = 3;
            var tomb = new Alkalmazott[n];

            DateTime egyik = new DateTime(1960, 10, 10);
            DateTime masik = new DateTime(1990, 10, 10);
            DateTime harmadik = new DateTime(1970, 10, 10);

            tomb[0] = new Alkalmazott("Pitchfork Ben Boogerbottom", egyik, 10000);
            tomb[1] = new Alkalmazott("Foncy Henderson", masik, 4000);
            tomb[2] = new Alkalmazott("Scut Listenbee", harmadik, 34556);

            foreach (var item in tomb)
            {
                System.Console.WriteLine(item);

            }
            Alkalmazott.NyugdíjkorhatárVáltoztatás(67);

            foreach (var item in tomb)
            {
                System.Console.WriteLine(item);
            }
            /* 
                  Írja ki azon alkalmazottak adatait, akiknek 5 évnél kevesebb van még hátra nyugdíjig.
                 Írja ki azoknak az alkalmazottaknak az adatait, akiknek az átlagnál több éve van még hátra
                nyugdíjig.
                  Rendezze az alkalmazottak tömbjét a nyugdíjig hátralévő évek alapján növekvő, majd pedig
                csökkenő sorrendbe.  */

            float nyugdíjÁtlag = 0;
            foreach (var item in tomb)
            {
                if (item.HányÉvedVanHátra() < 5)
                {
                    System.Console.WriteLine(item);
                }
                nyugdíjÁtlag += item.HányÉvedVanHátra();
            }

            nyugdíjÁtlag = nyugdíjÁtlag / n;

            System.Console.WriteLine("Neki(k) több van rip: \n ");
            foreach (var item in tomb)
            {
                if (item.HányÉvedVanHátra() > nyugdíjÁtlag)
                {
                    System.Console.WriteLine(item);
                }

            }

            System.Console.WriteLine("Sorted:\n");
            Array.Sort(tomb,
            delegate (Alkalmazott X, Alkalmazott Y) { return X.HányÉvedVanHátra().CompareTo(Y.HányÉvedVanHátra()); });
            for (var i = 0; i < n; i++)
            {
                System.Console.WriteLine(tomb[i]);

            }
            System.Console.WriteLine("Sorted Back:\n");
            for (var i = n - 1; i >= 0; i--)
            {
                System.Console.WriteLine(tomb[i]);

            }

            /*             
            b) Módosítsa az Alkalmazott osztály definícióját úgy, hogy ne az alkalmazott korát, hanem a
            születési dátumát tároljuk. A korát az aktuális év és a születési év különbségeként számítjuk.
            DateTime birthday = new DateTime(1955, 10, 28); //year, month, day
            DateTime currentDate = DateTime.Now;
            int currentYear = currentDate.Year; */









        }

    }

}