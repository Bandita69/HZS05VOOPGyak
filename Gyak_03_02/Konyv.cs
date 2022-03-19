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
        static readonly int megjelenes = DateTime.Today.Year;
        private int ar;
        private int page;

        public int getPage()
        {
            return this.page;
        }

        public void setPage(int page)
        {
            this.page = page;
        }

        static string kiado = "Móra";










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

        public int getAr()
        {
            return this.ar;
        }

        public void setAr(int ar)
        {
            this.ar = ar;
        }


        public Konyv(string cim, string szerzo, int megjelenes, int ar, int page)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            this.page = page;

            this.ar = ar;
        }

        public Konyv(string cim, string szerzo, int page) : this(cim, szerzo, DateTime.Now.Year, 2500, page)
        {



        }




        public override String ToString() { return "Könyv :" + cim + " " + szerzo + " " + megjelenes + " " + ar + " " + kiado + " " + page; }

        public void szazalekosAremelkedes(int szazalek)
        {
            setAr(ar + ar * szazalek / 100);


        }

        public static Konyv hosszabb(Konyv egyik, Konyv masik)
        {

            if (egyik.getPage() > masik.getPage())
            {
                return egyik;
            }
            else { return masik; }

        }

        public bool paros()
        {


            if (getPage() % 2 == 0)
            {
                return true;
            }
            else { return false; }
        }




    }

    public class Konyv_osztaly_hasznalo_osztaly
    {


        public static void Main(string[] args)
        {
            Konyv k = new Konyv("Nudlikevero Harmaik Bovitett kiadas", "Gordonka", 100);
            System.Console.WriteLine(k);
            k.szazalekosAremelkedes(10);
            System.Console.WriteLine(k);

            System.Console.WriteLine("Másik feladatok: \n");

            var tomb = new Konyv[3];






            tomb[0] = new Konyv("Nudlikevero Harmaik Bovitett kiadas", "Gordonka", 100);
            tomb[1] = new Konyv("Magyar Cinke fajok gondozása", "Gálik Tamás", 151);
            tomb[2] = new Konyv("Hogyan hagyjuk abba az izgulást és szeressük az oroszokat", "Gordonka", 120);
            Konyv legho = tomb[0];
            for (var i = 0; i < 3; i++)
            {
                legho = Konyv.hosszabb(legho, tomb[i]);

            }

            System.Console.WriteLine("leghosszabb " + legho);

            Konyv parosLegho = tomb[0];
            for (var i = 0; i < 3; i++)
            {

                if (tomb[i].paros())
                {
                    parosLegho = Konyv.hosszabb(parosLegho, tomb[i]);
                }


            }

            System.Console.WriteLine("paros leghosszabb " + parosLegho);




            var playersPerTeam =
                from Konyv in tomb
                group Konyv by Konyv.getSzerzo() into playerGroup
                select new
                {
                    Name = playerGroup.Key,
                    Count = playerGroup.Count(),
                };

                foreach (var item in playersPerTeam)
                {
                    System.Console.WriteLine(item);
                }






















        }
    }


}