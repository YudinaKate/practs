using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTA5_4
{
    interface ISpell
    {
        string Use();
        int Mana { get; set; }
        string Name { get; set; }
    }

    class Spell : ISpell
    {
        public int Mana { get;  set; }
        private string Effect { get; set; }
        public string Name { get;  set; }

        public Spell(int mana, string effect, string name)
        {
            Mana = mana;
            Effect = effect;
            Name = name;
        }

        public string Use()
        {
            return Effect;
        }
    }

    //Класс со свойствами мага
    class Magician
    {
        public string Name { get; private set; }
        public int Mana { get; private set; }

        public Magician(string name, int mana)
        {
            Name = name;
            Mana = mana;
        }

        public void CastSpell(ISpell spell)
        {
            if (Mana >= spell.Mana)
            {
                Console.WriteLine($"{Name} колдует! {spell.Use()}");
                Mana -= spell.Mana;
            }
            else
            {
                Console.WriteLine($"Для использования \"{spell.Name}\" не хватает {spell.Mana - Mana} маны");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ISpell akzhio = new Spell(50, "Притягивание предметов","Акцио");
            ISpell sectumsempra = new Spell(200, "Ранящее заклятие","Сектумсемпра");
            Magician Ron = new Magician("Рон Уизли", 50);
            Ron.CastSpell(akzhio);
            Ron.CastSpell(sectumsempra);

            Console.ReadKey(true);
        }
    }
}
