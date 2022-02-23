/* Deklaráljon egy string tömböt. A méretét olvassa be ellenőrzött módon; értéke 1 és 10 között
legyen. Olvasson be a tömbbe neveket.
a) Állapítsa meg, hány azonos név szerepel a tömbben. Két sztring azonos, ha a str1.Equals(str2)
hívás eredménye true. Az összehasonlítás kis- és nagybetű érzékeny.
b) Számolja meg, hány azonos kezdőbetűs névpár van a tömbben.
A karakterek az == operátorral összehasonlíthatók */
// "^[A-Z][a-zA-Z]*$"

using System;
using System.Text.RegularExpressions;
namespace MyNamespace4
{
    public class MyClass4
    {
        public static void Main(string[] args)
        {
            
            
            MyClass4 my = new MyClass4();
            double n = my.readDouble1es10Kozott();
            string[] tomb = new string[Convert.ToInt32(n)];
            for (var i = 0; i < n; i++)
            {
                tomb[i] = my.readValidNames();
            }
            foreach (var item in tomb)
            {
                System.Console.WriteLine(item);
            }
            

        }
        string readValidNames(){
            string nam= "";
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
            Console.WriteLine("Adj meg egy szamot");
            while
            (!(double.TryParse(Console.ReadLine(), out a)))
            {

                Console.WriteLine("Nem szam, probald ujra");



            }
            return a;



        }

        double readDouble1es10Kozott()
        {

            double a;

            do
            {
                System.Console.WriteLine("1 es 10 kozott");
                a = readDouble();
            } while (a < 1 || a > 10);
            return a;


        }

    }

}