using System;
using System.Text.RegularExpressions;
namespace MyNamespace31
{
    public class Alkalmazott



    {

        private string name;
        private int salary;

        public Alkalmazott(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public string getName()
        {

            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getSalary()
        {
            return this.salary;
        }

        public void setSalary(int salary)
        {
            this.salary = salary;
        }


        private void salaryInc(int increse)
        {


            setSalary(getSalary() + increse);


        }


        // - adjon vissza igazat, ha a fizetés a paraméterként megadott határok közé esik, és hamisat ha nem;
        public bool salaryHatarokKozt(int minimum, int maximum)
        {


            return (!(getSalary() < minimum || getSalary() > maximum));
        }

        // adja vissza a fizetendő adó értéket, ha az adókulcs 16% ;

        public double getAdo()
        {

            return getSalary() * 0.16;

        }

        //- adjon vissza igazat, ha a fizetés nagyobb, mint egy paraméterként megadott másik alkalmazotté.
        public bool nagyobbFizetes(int masikFizu)
        {

            return (getSalary() > masikFizu);

        }


        string readValidNames()
        {
            string nam = "";
            Console.WriteLine("Adj meg egy nevet");
        FIXME: // itt van valami hiba , de mukodik
            while (!nameCheck(nam = Console.ReadLine()))
            {
                Console.WriteLine("Nem jo nev, probald ujra");
            }
            return nam;



        }
        bool nameCheck(string nam)
        {

            var name = nam.Trim();
            if (!Regex.IsMatch(name, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                return false;
            }
            else { return true; }


        }

        double readDouble()
        {
            double a;
            Console.WriteLine("Adj meg a fizetest");
            while
            (!(double.TryParse(Console.ReadLine(), out a)))
            {

                Console.WriteLine("Nem jo, probald ujra");



            }
            return a;



        }

        public override string ToString()
        {
            return "Ember: " + name + " " + salary;
        }


        public static void Main(string[] args)
        {

            Alkalmazott alk = new Alkalmazott("Béla", 1000);
            System.Console.WriteLine(alk.ToString());
            System.Console.WriteLine(alk.salaryHatarokKozt(1050, 2000));
            alk.salaryInc(100);
            System.Console.WriteLine(alk.ToString());
            System.Console.WriteLine(alk.salaryHatarokKozt(1050, 2000));
            System.Console.WriteLine("Adó :" + alk.getAdo());
            System.Console.WriteLine("Nagyobb e a fiezetes mint a parameter " + alk.nagyobbFizetes(1000));

            /*   Az Alkalmazott osztályt használó osztályban deklaráljunk és beolvasással töltsünk fel adatokkal
 egy Alkalmazottakból álló 5 elemű tömböt. */
            int letszam = 5;
            Alkalmazott[] alkalmazotts = new Alkalmazott[letszam];
            for (var i = 0; i < letszam; i++)
            {
                alkalmazotts[i] = new Alkalmazott(alk.readValidNames(), Convert.ToInt32(alk.readDouble()));

            }

            // - Állapítsuk meg, hogy kinek a legmagasabb a fizetése
            double maximum = 0;
            string neki = "";
            int counter = 0;
            double sum = 0;
            double atlag = 0;
            
            foreach (var item in alkalmazotts)
            {
                if (item.getSalary() > maximum)
                {
                    maximum = item.getSalary();
                    neki = item.getName();
                }
                if (item.salaryHatarokKozt(1000, 2000))
                {
                    counter++;
                }
                sum = sum + item.getSalary();




            }
            atlag = sum / letszam;
            System.Console.WriteLine("Neki " + neki + " enniy:" + maximum);


            System.Console.WriteLine("Ennyinek esik 1000 és 2000 köze: " + counter);
            System.Console.WriteLine("Ennyi az atlag: " + atlag);

            //ADO JON


        }




    }
}