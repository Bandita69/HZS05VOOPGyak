using System;

namespace myNamespace.first
{
    public class Szám
    {
        static double tűrés = 0.001;
        private double valós;

        public double getValóS()
        {
            return this.valós;
        }

        public void setValóS(double valós)
        {
            this.valós = valós;
        }


        public Szám(double valós)
        {
            this.valós = valós;
        }

        public bool tűrésenBelül(double másikValós)
        {

            if (Math.Abs(másikValós - valós) <= tűrés)
            {

                return true;
            }
            else { return false; }

        }
    }


}

namespace myNamespace.second
{
    public class MyClass
    {


        public static void Main(string[] args)
        {

            Random rnd = new Random();
            double szám;
            szám = rnd.NextDouble();
            first.Szám my = new first.Szám(szám);
            int index = 0;

            do
            {
                szám = rnd.NextDouble();
                index ++;
                System.Console.WriteLine("ez a szám: " + my.getValóS() + " ez meg a másik: " + szám + " " + my.tűrésenBelül(szám));

            } while (!(my.tűrésenBelül(szám)));
            System.Console.WriteLine(index);





        }
    }
}

