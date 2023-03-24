using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTA3
{
    internal class Program
    {
         class Color
        {
            private int red;
            private int green;
            private int blue;
            public int Red {
                get
                {
                    return red;
                }
                set
                {
                    red = NormalizeColorValue(value);
                }
            }
            public int Green
            {
                get
                {
                    return green;
                }
                set
                {
                    green = NormalizeColorValue(value);
                }
            }
            public int Blue
            {
                get
                {
                    return blue;
                }
                set
                {
                    blue = NormalizeColorValue(value);
                }
            }
            public Color()
            {

            }
            public Color(int red, int green, int blue)
            {
                Red = red;
                Green = green;
                Blue = blue;
            }
            public void DisplayColor()
            {
                Console.WriteLine($"{red}, {green}, {blue}");
            }
            private int NormalizeColorValue(int colorValue)
            {
                if (colorValue > 255)
                {
                    return 255;
                }
                if (colorValue < 0)
                {
                    return 0;
                }
                return colorValue;
            }
        }
        static void Main(string[] args)
        {
            Color crimson = new Color(190, 38, 76);
            crimson.DisplayColor();
            Color gray = new Color();
            gray.Red = 180;
            gray.Green = 180;
            gray.Blue = 165;
            gray.DisplayColor();
            Console.ReadKey(true);
        }
    }
}
