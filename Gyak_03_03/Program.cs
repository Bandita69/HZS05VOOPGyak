/* Házi feladat:
a) Készítsen egy Személy osztályt az alábbi adatokkal: név, súly (egész, kilogrammban megadva),
magasság (valós, méterben megadva). Legyen egy metódusa, amely visszaadja a testtömeg indexet
(tti=tomeg/(m*m)). Legyen egy metódusa, amely visszaad egy alkatot jellemző szöveget:
"sovány": tti<18,5
"kövér": tti>25
"normál": egyébként
Legyen egy metódusa, amely egy sztringbe összefűzi az adatokat és visszaadja azokat az alábbi
alakban: név, súly, magasság, tti: alkat.
Készítsen egy futtatható osztályt, amelyben beolvassa egy személy adatait (név, súly, magasság) és
kiírja azokat összefűzve a kiszámított testtömeg indexszel és alkattal.
b) Írjunk setter metódusokat az adatok beállításához, és getter metódusokat az adatok
lekérdezéséhez (adatrejtés → ellenőrzött adathozzáférés).
 */

using System;
using System.Text.RegularExpressions;
namespace szemelyek
{
    public class Szemely
    {

        String name = "";
        int suly;
        double magassag;
        double tti;


        String alkat = "normál";

        public Szemely(String name, int suly, double magassag)
        {
            this.name = name;
            this.suly = suly;
            this.magassag = magassag;
            this.tti = (suly / (magassag * magassag));
        }


        public String getAlkat()
        {
            return this.alkat;
        }


        public double getTti()
        {
            return this.tti;
        }



        public String getName()
        {
            return this.name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public int getSuly()
        {
            return this.suly;
        }

        public void setSuly(int suly)
        {
            this.suly = suly;
        }

        public double getMagassag()
        {
            return this.magassag;
        }

        public void setMagassag(double magassag)
        {
            this.magassag = magassag;
        }

        public string testTomegIndex()
        {

            if (tti > 25) { alkat = "kövér"; }
            if (tti < 18.5) { alkat = "sovány"; }


            return alkat;
        }

        public override String ToString() { return "Program :" + name + " " + suly + " " + magassag + " " + tti + " " + testTomegIndex(); }



    }
    public class szemelyMain
    {
        public static void Main(string[] args)
        {
            Szemely sz = new Szemely("Bandika", 85, 1.9);
            System.Console.WriteLine(sz);
            System.Console.WriteLine("tti külön " + sz.getTti());

        }

    }
}