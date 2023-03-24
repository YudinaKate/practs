using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTA6_1
{
    class Transport
    {
        public string Name
        {
            get;
            set;
        }
        public int MaxSpeed
        {
            get;
            set;
        }
        public Transport(string name, int speed)
        {
            Name = name;
            MaxSpeed = speed;
        }
    }
    class PolytechMachine : Transport
    {
        public void Music()
        {
            Console.WriteLine("ЗВУК НАПОЛНУЮ!");
        }
        public PolytechMachine(string name, int speed)
            : base(name, speed)
        {
        }
    }
    class Airplane : Transport
    {
        public void PollinateField()
        {
            Console.WriteLine("Поле опылили");
        }
        public Airplane(string name, int speed)
            : base(name, speed)
        {
        }
    }
    class Mixer : Transport
    {
        public void MixConcrete()
        {
            Console.WriteLine("Бетон мешается");
        }
        public Mixer(string name, int speed)
            : base(name, speed)
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Transport Car = new Transport("BMW X5", 350);
            PolytechMachine Polytech = new PolytechMachine("Политех-машина!", 200);
            Polytech.Music();
            Airplane Boeing = new Airplane("LINER 2000", 956);
            Boeing.PollinateField();
            Mixer beton = new Mixer("Ураган", 300);
            beton.MixConcrete();
            Console.ReadKey(true);
        }
    }
}
