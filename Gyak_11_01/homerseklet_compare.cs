using System;
namespace homero
{
    public enum mertekegyseg
    {
        CELSIUS,
        KELVIN
    }
    public class Homerseklet : IComparable<Homerseklet>
    {



        double homerseklet;

        mertekegyseg _mert;

        public double getHomerseklet()
        {
            return this.homerseklet;
        }

        public void setHomerseklet(double homerseklet)
        {
            this.homerseklet = homerseklet;
        }

        public mertekegyseg get_mert()
        {
            return this._mert;
        }

        public void set_mert(mertekegyseg _mert)
        {
            this._mert = _mert;
        }



        public Homerseklet(double homerseklet, mertekegyseg mert)
        {
            this.homerseklet = homerseklet;
            this._mert = mert;
        }
        public Homerseklet(double homerseklet)
        {
            this.homerseklet = homerseklet;
            _mert = mertekegyseg.CELSIUS;
        }

        public static double homersekletetKonvertal(mertekegyseg _mert, double homerseklet)
        {

            return _mert == mertekegyseg.CELSIUS ? homerseklet + 273.15 : homerseklet - 273.15;
        }

        public int CompareTo(Homerseklet hom)
        {

            double temp = 0;
            double temp_this = 0;
            if (hom.get_mert() == mertekegyseg.CELSIUS)
            {
                temp = Homerseklet.homersekletetKonvertal(hom.get_mert(), hom.getHomerseklet());

            }
            else
            {
                temp = hom.getHomerseklet();
            }

            if (get_mert() == mertekegyseg.CELSIUS)
            {
                temp_this = Homerseklet.homersekletetKonvertal(get_mert(), getHomerseklet());

            }
            else
            {
                temp_this = getHomerseklet();
            }

            return (int)(temp_this - temp);




        }


        public override String ToString() { return "Homerseklet : " + _mert + " " + homerseklet; }



    }
    public class HomersekletProba
    {
        public static void Main(string[] args)
        {
            var tomb = new Homerseklet[4];
            var my = new HomersekletProba();

            Random rnd = new Random();

            tomb[0] = new Homerseklet(my.readDouble(), my.readString());
            tomb[1] = new Homerseklet(my.readDouble(), my.readString());
            tomb[2] = new Homerseklet(rnd.NextDouble() * 100, mertekegyseg.CELSIUS);
            tomb[3] = new Homerseklet(rnd.NextDouble() * 100, mertekegyseg.CELSIUS);
            my.tombKiir(tomb);


            System.Console.WriteLine(Homerseklet.homersekletetKonvertal(tomb[0].get_mert(), tomb[0].getHomerseklet()));
            System.Console.WriteLine(Homerseklet.homersekletetKonvertal(tomb[1].get_mert(), tomb[1].getHomerseklet()));
            System.Console.WriteLine(my.atlagHomersekletKelvin(tomb));



            foreach (var item in tomb)
            {
                System.Console.WriteLine(item);
            }

            Array.Sort(tomb);

            foreach (var item in tomb)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine(Array.BinarySearch(tomb,new Homerseklet(15)));

            List<Homerseklet> holista = new List<Homerseklet>(tomb);

            holista.Sort();
            System.Console.WriteLine(holista.BinarySearch(new Homerseklet(15)));


        }



        double atlagHomersekletKelvin(Homerseklet[] tomb)
        {
            double atlag = 0;
            double temp = 0;

            foreach (var item in tomb)
            {
                if (item.get_mert() == mertekegyseg.CELSIUS)
                {
                    temp = Homerseklet.homersekletetKonvertal(item.get_mert(), item.getHomerseklet());

                }
                else
                {
                    temp = item.getHomerseklet();
                }
                atlag += temp;
            }

            return atlag / tomb.Length;
        }
        void tombKiir(Homerseklet[] tomb)
        {

            foreach (var item in tomb)
            {
                System.Console.WriteLine(item);
            }

        }
        double readDouble()
        {
            double a;
            System.Console.WriteLine("Adjon meg egy szamot\n");
            while (!(double.TryParse(Console.ReadLine(), out a)))
            {
                System.Console.WriteLine("Tobbe-itt-ne-lassam");
            }

            return a;
        }

        mertekegyseg readString()
        {
            mertekegyseg a;
            System.Console.WriteLine("Adjon meg egy mertekegyseget\n");
            while (!(Enum.TryParse<mertekegyseg>(Console.ReadLine(), out a)))
            {
                System.Console.WriteLine("Tobbe-itt-ne-lassam");
            }


            return a;
        }

    }


}