using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTA2_2
{
    class CaesarScript
    {
        private string strCaesar;
        private int shift;
        public string GetCaesar()
        {
            return strCaesar;
        }
        public void SetCaesar(string code, int shift)
        {
            this.strCaesar = EncryptStr(code, shift);
            this.shift = shift;
        }
        private string EncryptStr(string code, int shift)
        {
            char[] alphabet = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            char x;
            int index;
            string stringCipher = "";
            for (int i = 0; i < code.Length; i++)
            {

                x = code[i];
                if (x == ' ')
                {
                    stringCipher += x;
                    continue;
                }
                index = Array.IndexOf(alphabet, x);
                index += shift;
                if (index > 32)
                {
                    index -= 33;
                }
                else if (index < 0)
                {
                    index += 33;
                }
                stringCipher += alphabet[index];
            }
            return stringCipher;
        }
        class Program
        {
            static void Main(string[] args)
            {
                CaesarScript Script = new CaesarScript();
                Script.SetCaesar("я программист", 11);
                Console.WriteLine(Script.GetCaesar());
                Script.SetCaesar("д фхузхесснцч", -5);
                Console.WriteLine(Script.GetCaesar());
                Console.ReadKey(true);
            }
        }
    }
}
