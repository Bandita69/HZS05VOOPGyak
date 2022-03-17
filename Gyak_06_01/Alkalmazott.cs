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
        int kor;
        int fizetés;


        static int nyugdíjkorhatár = 65;

        public Alkalmazott(string név, int kor, int fizetés)
        {
            this.név = név;
            this.kor = kor;
            this.fizetés = fizetés;
        }

        public Alkalmazott(string név, int kor) : this(név, kor, 10000 * kor)
        {

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

    }

}