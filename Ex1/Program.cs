using System;
using System.Collections.Generic;

namespace Ex1
{
    class Program
    {
        public static bool stijgend(int a, int b)
        {
            if (a < b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me input: a few numbers seperated by hyphen (-)");
            var inp_numbers_hyphen = Console.ReadLine().Trim();
            bool stijgen, dalen = false;
            Console.WriteLine("you typed:" + inp_numbers_hyphen);
            var getallen = inp_numbers_hyphen.Split('-');
            var reeks=new List<bool>();
            foreach (var getal in getallen)
            {
                Console.WriteLine(getal);

            }
            for (int i = 0; i < getallen.Length - 1; i++)
            {
                if (stijgend(int.Parse(getallen[i]), int.Parse(getallen[i + 1])))
                {
                    stijgen = true;
                    reeks.Add(stijgen);

                }
                else
                {
                    dalen = true;
                    stijgen = false;
                }
                reeks.Add(stijgen);
                Console.WriteLine("stijgend=" + stijgen + " : " + dalen);
                stijgen = false;
                dalen = false;
            }
            Console.WriteLine("Tweede getal=" + getallen[1]);
            if (reeks.Contains(true) && reeks.Contains(false))
            {
                Console.WriteLine("ai ai");
            }
            else
            {
                Console.WriteLine("Prima");
            }
        }
    }
}
