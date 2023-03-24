using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTA4
{
    class Spell
    {
        public int Mana { get; private set; }
        private string Effect { get; set; }
        public string Name { get; private set; }
        public Spell(int Mana, string Effect, string Name)
        {
            Mana = Mana;
            Effect = Effect;
            Name = Name;
        }

        public string Using()
        {
            return Effect;
        }
        class Magician
    {
        public string Name { get; private set; }
        public int Mana { get; private set; }
        public Magician(string Name, int Mana)
        {
            Name = Name;
            Mana = Mana;
        }

        public void CastSpell(Spell Spell)
        {
            if(Mana >= Spell.Mana)
            {
                Console.WriteLine($"{Name} колдует! {Spell.Using()}");
                Mana -= Spell.Mana;
            }
            else
            {
                Console.WriteLine($"Для использования \"{Spell.Name}\" не хватает {Spell.Mana-Mana} маны");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Spell akzhio = new Spell(50, "Притягивание предметов","Акцио");
            Spell sectumsempra = new Spell(200, "Ранящее заклятие","Сектумсемпра");
            Magician Ron = new Magician("Рон Уизли", 50);
            Ron.CastSpell(akzhio);
            Ron.CastSpell(sectumsempra);
            
            Console.ReadKey(true);
        }
    }
    }
}


