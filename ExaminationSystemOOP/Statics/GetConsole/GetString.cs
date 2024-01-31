using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemOOP.Statics.GetConsole
{
    internal class GetString
    {
        public static string GetStringValue(int minLength)
        {
            string text = "";
            bool Validation = false;
            while (!Validation)
            {
                text = Console.ReadLine() ?? "";
                if (text.Length >= minLength)
                {
                    Validation = true;
                }
                else
                {
                    Console.WriteLine($"Enter At Least {minLength} Chars");
                }
            }

            return text;
        }

        public static string GetStringValue()
        {
            return Console.ReadLine() ?? "";
        }
    }
}
