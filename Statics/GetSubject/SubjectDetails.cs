using ExaminationSystemOOP.Statics.GetConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemOOP.Statics.GetSubject
{
    internal class SubjectDetails
    {
        public static int GetSubjectId()
        {
            Console.WriteLine("Please Enter Subject Id");
            return GetNumber.GetIntegerValue();
        }

        public static string GetSubjectName()
        {
            const int MinLength = 3;

            Console.WriteLine("Please Enter Subject Name");
            return GetString.GetStringValue(MinLength);
        }
    }
}
