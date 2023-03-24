using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTA6_2
{
    class Human
    {
        public string Name { get; private set; }
        public byte Age { get; private set; }
        public char Sex { get; private set; }

        public Human(string man, byte age, char sex)
        {
            Name = man;
            Age = age;
            Sex = sex;
        }
    }

    class Worker : Human
    {
        public string JobTitle { get; private set; }
        public Worker(string man, byte age, char sex, string jobtitle)
            : base(man, age, sex)
        {
            JobTitle = jobtitle;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Worker Sergeevich = new Worker("Максим Рязанов Сергеевич", 20, 'М', "Водитель");
            Worker Sergeevna = new Worker("Екатерина Юдина Сергеевна", 56, 'Ж', "Секретарь");
            Console.WriteLine("Перепись работников завод по обработке тяжелых металлов" +
                "\nИмя                          \tДолжность \tВозраст\tПол");
            Console.WriteLine($"{Sergeevich.Name}    \t{Sergeevich.JobTitle}\t{Sergeevich.Age}\t{Sergeevich.Sex}");
            Console.WriteLine($"{Sergeevna.Name}\t{Sergeevna.JobTitle}    \t{Sergeevna.Age}\t{Sergeevna.Sex}");
            Console.ReadKey();
        }
    }
}
