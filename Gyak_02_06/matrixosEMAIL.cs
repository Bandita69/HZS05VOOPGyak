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
            string[,] matrix = new string[5, 3];


            for (var i = 0; i < numberOfNames; i++)
            {
                matrix[i, 0] = my.readValidNames();
                matrix[i, 1] = my.readValidEmails();
                if (matrix[i, 1] != "")
                {
                    matrix[i, 2] = my.readValidEmails();
                }



            }
            var tobbEmail = 0;
            for (var i = 0; i < numberOfNames; i++)
            {

                if (!(String.IsNullOrEmpty(matrix[i, 2])))
                {
                    tobbEmail++;

                }

            }
            System.Console.WriteLine("ennyinek van tobb: " + tobbEmail);



        }

        string readValidEmails()
        {
            string nam = "";
            Console.WriteLine("Adj meg egy emailt");
        FIXME: // itt van valami hiba , de mukodik
            while (!Validator.EmailIsValid(nam = Console.ReadLine()))
            {
                if (nam == "") { return nam; }
                Console.WriteLine("Nem jo email, probald ujra");
            }
            return nam;



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

    public static class Validator
    {

        static Regex ValidEmailRegex = CreateValidEmailRegex();

        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        internal static bool EmailIsValid(string emailAddress)
        {
            bool isValid = ValidEmailRegex.IsMatch(emailAddress);

            return isValid;
        }
    }
}