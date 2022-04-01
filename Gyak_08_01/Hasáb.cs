// 8. feladat absractos valami
/* 1. Készítsen saját névtérben Hasáb absztrakt osztályt.
Adattagja: magasság (int)
Konstruktora: a paraméterben kapott értékkel inicializálja a magasságot
Metódusok:
- Getter metódus, amely visszaadja a magasságot.
- Absztrakt (abstract) metódus az alapterület visszaadására.
- Metódus a térfogat visszaadására.
- Összehasonlító metódus, amely igazat ad vissza, ha a hasáb nagyobb térfogatú, mint egy
paraméterben kapott másik hasáb térfogata.
 */
using System;
namespace HasabNevter
{
    public abstract class Hasáb
    {
        protected int magasság;


        protected int getMagassáG()
        {
            return this.magasság;
        }

        protected void setMagassáG(int magasság)
        {
            this.magasság = magasság;
        }

        protected Hasáb(int magasság)
        {
            this.magasság = magasság;
        }

        public abstract double alapterület();


        public double getTerfogat()
        {

            return magasság * alapterület();

        }

        public bool nagyobbTerfogat(Hasáb masik)
        {

            if (masik.getTerfogat() < getTerfogat())
            {
                return true;
            }
            else
            {
                return false;
            }

        }





    }

    /* 
        Ugyanebben a névtérben készítsen Henger osztályt, amely a Hasáb leszármazottja.
    Adattagja: sugár (double)
    Konstruktor: a paraméterben kapott sugár és magasság értékekkel inicializálja az objektumot
    Metódusok:
    - Definiálja felül az örökölt alapterületet visszaadó metódust.
    - Definiálja felül a ToString() metódust: ez összefűzve adja vissza a henger sugarát, magasságát és
    térfogatát. */


    public class Henger : Hasáb
    {
        double sugár;

        public Henger(double sugár, int magasság) : base(magasság)
        {
            this.sugár = sugár;

        }

        public override double alapterület()
        {
            return sugár * Math.PI * Math.PI;


        }

        public override String ToString() { return "Henger sugár:" + sugár + " magasság: " + getMagassáG() + " terület: " + getTerfogat() + " "; }

    }

    /* 
        Készítsen ugyanebben a névtérben Téglatest osztályt, amely a Hasáb leszármazottja.
    Adattagjai: az alap két oldala (double)
    Konstruktor: a három adattagot a paraméterben megkapott értékkel inicializálja
    Metódusok:
    - Definiálja felül az örökölt alapterületet visszaadó metódus.
    - Definiálja felül a ToString() metódust: ez összefűzve adja vissza a téglatest alapjának oldalait,
    magasságát és térfogatát. */


    public class Téglatest : Hasáb
    {
        double egyikoldal, másikoldal;

        public Téglatest(double egyikoldal, double másikoldal, int magasság) : base(magasság)
        {
            this.egyikoldal = egyikoldal;
            this.másikoldal = másikoldal;
        }


        public override double alapterület()
        {

            return egyikoldal * másikoldal;
        }

        public override String ToString() { return "Téglatest :" + egyikoldal + " " + másikoldal + " " + getMagassáG() + " " + getTerfogat(); }


    }



}

/* Alnévtérben készítsen futtatható osztályt, amelyben létrehoz egy hengert, majd kiírja az adatait és a
térfogatát. Hozzon létre egy téglatestet és írja ki az adatait és a térfogatát, majd azt, hogy melyik a
nagyobb térfogatú hasáb.
 */

/* 
 Készítsen az előbbi futtatható osztályban egy 5 elemű hasáb-tömb objektumot. A tömb elemeinek
adjon értéket úgy, hogy legyen null értékű tömbelem is. Két henger és egy téglatest adatait olvassa
be. Írja ki az összes hasáb adatát, majd a hasábok átlagos térfogatát, és a hengerek számát. */

namespace AlNevterHasab
{
    public class futtathatoOsztály
    {
        public static void Main(string[] args)
        {
            var hengi = new HasabNevter.Henger(3, 10);
            System.Console.WriteLine(hengi);
            var teglatesuwudesugozejmaaaasz = new HasabNevter.Téglatest(2, 3, 100);
            System.Console.WriteLine(teglatesuwudesugozejmaaaasz);

            if (hengi.nagyobbTerfogat(teglatesuwudesugozejmaaaasz))
            {
                System.Console.WriteLine(hengi + "  a nagyobb");
            }
            else
            {
                System.Console.WriteLine(teglatesuwudesugozejmaaaasz + " a nagyobb");
            }

            HasábTárolóNévtér.Tároló fstartaly = new HasábTárolóNévtér.Tároló(5);
            fstartaly.setTomb(0,hengi);
            fstartaly.setTomb(1,teglatesuwudesugozejmaaaasz);
            var huncutmokus = new HasabNevter.Téglatest(3, 3, 10);
            fstartaly.setTomb(2,huncutmokus);

            System.Console.WriteLine(fstartaly.getTombMeret());
            System.Console.WriteLine(fstartaly.getAtlagosTerfogat());
            System.Console.WriteLine(fstartaly.getTomb()[0]);
            System.Console.WriteLine(fstartaly.getTomb()[1]);
            System.Console.WriteLine(fstartaly.getTomb()[2]);
            
            


        }
    }

    /* 
        Készítsen új névtérben egy olyan osztályt, amely hasábokat képes tárolni.
    Adattagja: Hasáb típusú tömb adattag
    Konstruktor: paraméterben megkapja a hasábok maximális számát és ezzel a mérettel hozza létre a
    tömböt.
    Metódusok:
    - Setter metódus, amely paraméterben megkap egy indexet és egy hasábot, és a tömb adott indexű
    elemének értékül adja a kapott hasáb referenciáját.
    - Getter metódus, amely visszaadja a tömb méretét, azaz a hasábok maximális számát.
    */


    namespace HasábTárolóNévtér
    {
        public class Tároló
        {

            HasabNevter.Hasáb[] tomb;

            //ENNEK LEHET VAN JOBB MEGOLDÁSA IS
            public HasabNevter.Hasáb[] getTomb()
            {
                return this.tomb;
            }





            public Tároló(int n)
            {
                tomb = new HasabNevter.Hasáb[n];

            }

            public void setTomb(int index, HasabNevter.Hasáb krupmli)


            {
                tomb[index] = krupmli;
            }

            public int getTombMeret()
            {

                int n = 0;
                foreach (var item in tomb)
                {
                    if (item != null)
                    {
                        n++;
                    }
                    
                }
                return n;

            }
            /* 
                - Getter metódus, amely paraméterként egy indexet kap és visszaadja a tömb adott indexű elemét.
                - Getter metódus, amely visszaadja, hogy hány darab nem null értékű tömbelem van.
                - Getter metódus, amely visszaadja a hasábok átlagos térfogatát.
                - Getter metódus, amely visszaadja a Henger típusú hasábok számát.  */

            public HasabNevter.Hasáb getIndexElem(int index)
            {

                return tomb[index];

            }


            public double getAtlagosTerfogat()
            {
                double sum = 0;
                foreach (var item in tomb)
                {
                    if (item != null)
                    {
                        sum += item.getTerfogat();
                    }
                    
                }
                return sum /= getTombMeret();

            }


            public int getHengerTipus()
            {
                int sum = 0;
                foreach (var item in tomb)
                {
                    if (item.GetType() == typeof(HasabNevter.Henger))
                    {
                        sum++;
                    }
                }
                return sum;


            }





        }

    }




}