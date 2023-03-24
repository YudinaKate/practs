using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTA4_1
{
    class Parcel
    {
        public string OpisanieParcel { get;  private set; }
        public static double MassParcel { get; private set; }
        public string To { get; private set; }
        public string Name { get; private set; }
        public Parcel(double mass, string about, string to, string name)
        {
            OpisanieParcel = about;
            MassParcel = mass + MassParcel;
            To = to;
            Name = name;
        }

    }

    class SrvDeliver
    {
        private int LimitMass = 40;
        public void sendParcel(Parcel parcel)
        {
          if(Parcel.MassParcel > LimitMass)
          {
            Console.WriteLine($"Вес посылки больше на {Parcel.MassParcel - limitMass} кг");
          }
          else
          {
             Console.WriteLine($"Посылка {parcel.Name}, отправлена в {parcel.To}");
          }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SrvDeliver Pochta = new SrvDeliver();
            Console.Write($"Здравствуйте, я являюсь \"Корресподентом-101\"!" +
                $"\nМы отправим посылку, если она не превышает меру" +
                $"\nВведите пожалуйста данные вашей посылки (Название/Описание/Вес/Назначение): ");
            string corrInf = Console.ReadLine();
            string[] correspodentInf = corrInf.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); ;
            Parcel bander = new Parcel(Convert.ToDouble(correspodentInf[2]),correspodentInf[1],correspodentInf[3],correspodentInf[0]);

            Pochta.sendParcel(bander);
            Console.ReadKey(true);
        }
    }
}
