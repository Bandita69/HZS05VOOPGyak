/*  Egy string mátrixba olvasson be 5 nevet és a hozzá tartozó email címeket. Hány embernek van
egynél több email címe? */

using System;
using System.Text.RegularExpressions;
namespace name6
{
    public class MyClass6
    {
        public static void Main(string[] args)
        {

            int numberOfNames = 5;
            MyClass6 my = new MyClass6();
            string[,] matrix = new string[5,3];


            for (var i = 0; i < numberOfNames; i++)
            {
                matrix[i,0] = my.readValidNames();
                System.Console.WriteLine("email1");
                matrix[i,1] = my.readValidNames();
                System.Console.WriteLine("email2");
                matrix[i,2] = my.readValidNames();
               

            } // TODO: Elképzelés az hogy a tömbon végig megy ahol van email a 3. oszlopban, osszeadja. de itt inkább az email beolvasás a feladat



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

    }

}