/* 2. Készítsen saját névtérben ISzinezheto néven interfészt.
Tulajdonságai (property-k):
- legyen tulajdonsága beállítani/lekérdezni egy szín értékét,
- legyen egy csak olvasható tulajdonsága, amely visszaadja az alapértelmezett színt. */

using System;

namespace isSzinehezoNevter
{
    public interface ISzinezheto
    {
        public int szín { get; set; }
        public int színDefault { get; }

    }
}


/* Készítsen másik névtérben Pont osztályt.
Adattagja: x és y koordináta (int)
Konstruktor: két megkapott paraméterrel inicializálja az adattagokat
Metódus:
- Definiálja felül a ToString() metódust, amely sztringben összefűzve adja vissza a pont adatait.
 */

namespace pontNevtér
{
    public class Pont
    {
        int x, y;

        public Pont(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override String ToString() { return "Pont adatai(x,y) :" + x + " " + y; }
    }
    /* 
    Készítsen Szinespont osztályt a Pont osztályból származtatva.
    Adattagja: szín (int, vagy enum) és alapértelmezett szín (értéke 0)
    Konstruktor:
    - Paraméter nélküli. A szín az alapértelmezett szín, a pont koordinátái: 0, 0.
    - Csak a szín paraméter megadásával inicializálja az adatokat. A pont koordinátái: 0, 0.
    - Három megkapott paraméterrel inicializálja az adatokat.
    Metódusok:
    - Definiálja felül az Object osztálytól örökölt ToString() metódust.
    - Implementálja a ISzinezheto interfészt. */



    public class SzinesPont : Pont, isSzinehezoNevter.ISzinezheto
    {
        enum Színek
        {
            Feher,
            Kek,
            Zold,
            Piros

        }


        public int szín { get; set; }
        public int színDefault { get; private set; } = 0;


        public SzinesPont() : base(0, 0)
        {

        }

        public SzinesPont(int szín) : base(0, 0)
        {
            this.szín = szín;
        }

        public SzinesPont(int színPar, int x, int y) : base(x, y)
        {
            this.szín = szín;
        }

        public override String ToString() { return "SzinesPont :" + base.ToString() + " Színe: " + (Színek)szín; }







    }




}

/* 
Új névtérben készítsen Áru osztályt (products.Product, lásd 7. gyakorlat 1. feladat), majd ugyanitt
egy Toll osztályt az Áru osztály leszármazottjaként.
*/


namespace ÁruNévtér
{
    public class Product
    {
        string név;
        int netto;
        int afa;

        public Product(string név, int netto, int afa)
        {
            this.név = név;
            this.netto = netto;
            this.afa = afa;
        }



        public int brutto()
        {

            return netto + (netto * afa / 100);

        }


        public override String ToString() { return "Product :" + név + " " + brutto(); }

        public void szazalekosAremelkedes(int szazalek)
        {

            netto *= ((100 + szazalek) / 100);
        }

        public int melyikADragabb(Product masik)
        {
            if (brutto() > masik.brutto())
            {
                return 1;
            }
            else if (brutto() < masik.brutto())
            {
                return -1;
            }
            else
            {
                return 0;
            }



        }


    }

    /* 
    Adattagjai: alapértelmezett szín, szín és márkanév
    Konstruktor:
    - Három adatot kap paraméterként (márka, szín, ár), a termék megnevezése toll, az áfa 27%.
    Metódusok:
    - Definiálja felül az örökölt ToString() metódust.
    - Implementálja a ISzinezheto interfészt.  */



    public class Toll : Product, isSzinehezoNevter.ISzinezheto
    {

        enum Színek
        {
            Feher,
            Kek,
            Zold,
            Piros

        }

        string márkanév;


        public int szín { get; set; }
        public int színDefault { get; private set; } = 0;


        public Toll(string márkanév, int szín, int ár) : base(márkanév, ár, 27)
        {
            this.szín = szín;
            this.márkanév = márkanév;
        }


        public override String ToString() { return "Áru :" + base.ToString() + " Színe " + (Színek)szín; }






    }


}


/* Készítsen egy futtatható osztályt új névtérben, amelyben egy ISzinezheto típusú referenciának
Szinespont példányt ad értékül, kiírja az adatait, majd átszínezi és újra kiírja az adatait. Ugyanezt
próbálja ki egy Toll objektummal is.
Készítsen a futtatható osztályban egy static metódust az alapértelmezett szín visszaállítására
(SetDefaultColor). Ez paraméterként egy ISzinezheto objektumot vár és az objektum színét átállítja
az alapértelmezett színre. Használja a Szinespont és a Toll objektum színének beállítására!
Ismerkedjen meg a ConsoleColor enummal, és a System.Drawing.Color struktúrával!
 */

namespace futtathatoNevterSzin
{
    public class main
    {
        public static void Main(string[] args)
        {




        }

    }
}



