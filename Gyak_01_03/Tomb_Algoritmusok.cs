namespace harmadik

{
    public class TombAlgoritmusok
    {
        public static void Main(string[] args)
        {
            int[] tomb = new int[10];
            for (var i = 0; i < tomb.Length; i++)
            {
                tomb[i] = i;
            }
           
            TombAlgoritmusok my = new TombAlgoritmusok();
            my.TombKiir(tomb);
            my.TombKiirForditva(tomb);
            System.Console.WriteLine(my.ParosSzamokAtlaga(tomb));
            System.Console.WriteLine(my.MinimumKeres(tomb));
            System.Console.WriteLine(my.MonotonE(tomb));
            my.TombKiir(my.NovekvoRendezes(tomb));


        }

        void TombKiir(int[] tomb)
        {
            foreach (var item in tomb)
            {
                System.Console.WriteLine(item);
            }


        }
        void TombKiirForditva(int[] tomb)
        {
            for (int i = tomb.Length - 1; i >= 0; i--)
            {

                System.Console.WriteLine(tomb[i]);

            }


        }

        float ParosSzamokAtlaga(int[] tomb)
        {
            float sum = 0;
            float n = 0;
            foreach (var item in tomb)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                    n++;
                }
            }




            return sum / n;
        }

        float MinimumKeres(int[] tomb)
        {
            float min = tomb[0];
            foreach (var item in tomb)
            {
                if (item < min)
                {
                    min = item;
                }
            }



            return min;
        }

        bool MonotonE(int[] tomb)
        {
            float monocheck = tomb[0];

            for (var i = 1; i < tomb.Length; i++)

            {
                if (tomb[i] >= monocheck)
                {
                    monocheck = tomb[i];
                }
                else return false;
            }



            return true;
        }

        int[] NovekvoRendezes(int[] tomb)
        {

            int[] tomb2 = tomb;
            Array.Sort(tomb2);


            return tomb2;


        }




    }
}