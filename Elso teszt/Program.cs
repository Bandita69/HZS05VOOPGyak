using System;
class Hello
{
    static void Main()
    {

        int egyszam = 1;
        int[] szamok = { 1, 2, 3 };

        Console.WriteLine(egyszam);
        foreach (var item in szamok)
        {
            Console.WriteLine(item);
        }


    //file stuff
    string filename = "test.txt";

    //delete
    if (System.IO.File.Exists(filename))
    {
        System.IO.File.Delete(filename);
    }

// file create
    using System.IO.FileStream fs = System.IO.File.Create(filename,1024);
   
   byte[] szomtext = new System.Text.UTF8Encoding(true).GetBytes("Ez valami text egy fileba");
   fs.Write(szomtext,0,szomtext.Length);
    fs.Close();

//file read
    using System.IO.StreamReader sr = System.IO.File.OpenText(filename);
    string? s;
    do
    {
        s = sr.ReadLine();
        System.Console.WriteLine(s);
        
    } while (s != null);
    sr.Close();





    }
}