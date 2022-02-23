using System;
namespace MyNamespace
{
    

public class MyClass
{
    public static void Main(string[] args)
    {
        MyClass mc = new MyClass();
        int n = 10000;
        System.Console.WriteLine("Pi értéke Leibinz- formulaval ( n: {1} ): {0} ", mc.leibiz(n), n);
        System.Console.WriteLine("Pi értéke Wallis-formulaval ( n: {1} ): {0} ", mc.wallis(n), n);
        System.Console.WriteLine("Euler fele e szam kozelitese: {0}", mc.Euler(11));
    }


    float leibiz(int n)
    {

        float oszto = 1;
        float sum = 0;
        for (var i = 1; i <= n / 2; i++)
        {
            sum += (1 / oszto);
            oszto += 2;
            sum -= (1 / oszto);
            oszto += 2;
        }
        return sum * 4;
    }

    float wallis(int n)
    {
        float szamlalo = 2;
        float oszto = 1;
        float sum = 1;
        for (var i = 0; i <= n / 2; i++)
        {

            sum *= szamlalo / oszto;
            oszto += 2;
            sum *= szamlalo / oszto;
            szamlalo += 2;

        }
        return sum * 2;
    }

    float Euler(int n){
        float sum = 1;
        for (var i = 1; i <= n; i++)
        {
            sum = sum + 1/fakt(i);
        }
        return sum;

    }

    float fakt(int szam){
        float sum = 1;
        for (var i = 1; i <= szam; i++)
        {
            sum = sum *i;
        }
        return sum;
    }
}

}