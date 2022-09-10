using System;
using System.Text;

namespace Hollow
{
    public class Utils
    {
        public static void Banner()
        {
            string art = "IF8gIF8gICAgICAgXyAgXyAgICAgICAgICAgICAgIA0KfCB8fCB8IF9fXyB8IHx8IHwgX19fICBfIF9fIF9fIA0KfCBfXyB8LyBfIFx8IHx8IHwvIF8gXCBcIFYgIFYgLw0KfF98fF98XF9fXy98X3x8X3xcX19fLyAgXF8vXF8vIA0K";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(art)));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Hollow: 1.0.0");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("repository: github.com/HSNHK/Hollow");
            Console.WriteLine("twitter: twitter.com/0xHSNHK\n");
            Console.ResetColor();
        }
    }
}
