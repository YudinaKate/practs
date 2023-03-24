using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTA5_1
{
    interface IHello
    {
        void SayHello();
    }

    class EnHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello! I am from Britain");
        }
    }

    class FrBon : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Bonjour! Je viens de France");
        }
    }

    class IspSoy : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hola! Soy de España");
        }
    }

    class Program
    {
             static void Main(string[] args)
        {
            //Инициализация коллекции 
            List<IHello> interNatHello = new List<IHello>();

            //Инициализации элементов коллекции с интерфейсом и дочерним классом
            interNatHello.Add(new EnHello());
            interNatHello.Add(new FrBon());
            interNatHello.Add(new IspSoy());

            //Перебор элементов и вывод 
            foreach(IHello interhello in interNatHello)
            {
                interhello.SayHello();
            }

            Console.ReadKey();
        }
    }
}

