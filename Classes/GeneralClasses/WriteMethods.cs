using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG.Classes.GeneralClasses
{
    internal class WriteMethods
    {
        public static void WriteSeparator()
        {
            Console.WriteLine("---------------------");
        } 

        public static void WriteGreenLine(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void WriteRedLine(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void WriteBlueLine(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void WriteGrayLine(string value)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(value);
            Console.ResetColor();
        }

        public static void WriteGreen(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void WriteRed(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void WriteBlue(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void WriteGray(string value)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(value);
            Console.ResetColor();
        }

    }
}
