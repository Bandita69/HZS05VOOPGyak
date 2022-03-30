using System;

namespace myproducts
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

            return netto + (netto * afa/100) ;

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

    public class Kenyér : Product
    {
        double mennyiség;

        public double getMennyiséG()
        {
            return this.mennyiség;
        }

        public void setMennyiséG(double mennyiség)
        {
            this.mennyiség = mennyiség;
        }


        public Kenyér(double mennyiség, string név, int netto, int afa) : base(név, netto, afa)
        {
            this.mennyiség = mennyiség;
        }
        

        public override String ToString() { return base.ToString() + " Egységár " + brutto() / mennyiség; }

        public static bool melyikKenyerKenyerebb(Kenyér egyik, Kenyér masik)
        {
            if (egyik.brutto() / egyik.getMennyiséG() > masik.brutto() / masik.getMennyiséG())
            {
                return true;
            }
            else { return false; }



        }



    }
    public class main
    {
        public static void Main(string[] args)
        {

            Product Áru = new Product("Zsepi", 1000, 25);
            Kenyér Kenyér = new Kenyér(1, "Barna", 500, 24); 
            Kenyér Kenyér2 = new Kenyér(1, "Feher", 600, 34); 
            Product Áru2 = new Kenyér(1, "Zsemle", 400, 25); 


            System.Console.WriteLine(Áru);
            System.Console.WriteLine(Kenyér);
            System.Console.WriteLine(Áru.melyikADragabb(Kenyér));
            System.Console.WriteLine(Áru2);

           System.Console.WriteLine(Kenyér.melyikKenyerKenyerebb((Kenyér)Áru2,Kenyér2));



        }

    }

}