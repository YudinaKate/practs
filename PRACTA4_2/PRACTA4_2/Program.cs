using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTA4_2
{
    class Orc
    {
        private static int Counter;
        public static int KolichAllGold
        {
            get;
            private set;
        }
        public int KolichGold
        {
            get;
            private set;
        }
        public Orc()
        {
            Counter++;
            KolichAllGold += 2;
            if (Counter > 5)
            {
                KolichGold += 2;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Orc orc_1 = new Orc();
            Console.WriteLine(Orc.KolichAllGold);
            Orc orc_2 = new Orc();
            Orc orc_3 = new Orc();
            Console.WriteLine(Orc.KolichAllGold);
            Orc orc_4 = new Orc();
            Orc orc_5 = new Orc();
            Orc orc_6 = new Orc();
            Orc orc_7 = new Orc();
            Console.WriteLine(orc_7.KolichGold);
            Console.ReadKey(true);
        }
    }
}
