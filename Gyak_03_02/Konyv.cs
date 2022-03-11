/* 2. Készítsen Könyv osztályt és egy Könyv osztályt használó osztályt.
a) A Könyv osztály adattagjai: cím, szerző, megjelenés éve, ára. Legyen egy metódusa, amely a
paraméterként kapott százalékos értékkel növeli a könyv árát. Legyen egy metódusa, ami egy
sztringbe összefűzi az adatokat és ezt adja vissza. Írjunk setter metódusokat az adatok beállításához,
és getter metódusokat az adatok lekérdezéséhez (adatrejtés → ellenőrzött adathozzáférés).
b) A Könyv osztályt használó osztályban hozzunk létre egy könyvet és kérdezzük le az adatait */

using System;
using System.Text.RegularExpressions;
namespace konyvek
{
    public class Konyv
    {
        private String cim;
        private String szerzo;
        private int megjelenes;
        private int ar;










        public String getCim()
        {
            return this.cim;
        }

        public void setCim(String cim)
        {
            this.cim = cim;
        }

        public String getSzerzo()
        {
            return this.szerzo;
        }

        public void setSzerzo(String szerzo)
        {
            this.szerzo = szerzo;
        }

        public int getMegjelenes()
        {
            return this.megjelenes;
        }

        public void setMegjelenes(int megjelenes)
        {
            this.megjelenes = megjelenes;
        }

        public int getAr()
        {
            return this.ar;
        }

        public void setAr(int ar)
        {
            this.ar = ar;
        }


        public Konyv(string cim, string szerzo, int megjelenes, int ar)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            this.megjelenes = megjelenes;
            this.ar = ar;
        }

        public Konyv(string cim, string szerzo) : this(cim, szerzo, DateTime.Now.Year, 2500)
        {



        }




        public override String ToString() { return "Könyv :" + cim + " " + szerzo + " " + megjelenes + " " + ar; }

        public void szazalekosAremelkedes(int szazalek)
        {
            setAr(ar + ar * szazalek / 100);


        }





    }

    public class Konyv_osztaly_hasznalo_osztaly
    {


        public static void Main(string[] args)
        {
            Konyv k = new Konyv("Nudlikevero Harmaik Bovitett kiadas", "Gordonka");
            System.Console.WriteLine(k);
            k.szazalekosAremelkedes(10);
            System.Console.WriteLine(k);



        }
    }


}