using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTA5_2
{
    interface IFilter
    {
        string Execute(string textLine);
    }

    class DigitFilter : IFilter
    {
        public string Execute(string textline)
        {
            return string.Concat(textline.Split("1234567890".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
        }
    }

    class LetterFilter : IFilter
    {
        public string Execute(string textline)
        {
            return string.Concat(textline.Split("АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯяAaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz"
                .ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFilter digfilter = new DigitFilter();
            IFilter letterfilter = new LetterFilter();
            string outString;
            Console.Write("Вас встречает \"Filter\"!" +
                "\n* Преимущества:" +
                "\n* Удаление букв кириллицы;" +
                "\n* Удаление чисел" +
                "\n" +
                "\nВыберите действие (Ж/Ц/К): ");
            char answ = char.Parse(Console.ReadLine());
            Console.Write("Введите вашу строку: ");
            string inString = Console.ReadLine();
            if (answ == 'Ж' | answ == 'ж')
                outString = letterfilter.Execute(inString);
            else if (answ == 'Ц' | answ == 'ц')
                outString = digfilter.Execute(inString);
            else if (answ == 'К' | answ == 'к')
                outString = letterfilter.Execute(digfilter.Execute(inString));
            else
                outString = "Ошибка ";
            Console.WriteLine(outString);
            Console.ReadKey();
        }
    }
}
