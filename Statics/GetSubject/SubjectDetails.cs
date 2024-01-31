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
        #region GetSubjectId
        public static int GetSubjectId()
        {
            Console.Write("Please Enter Subject Id: ");
            return GetNumber.GetIntegerValue();
        }
        #endregion

        #region GetSubjectName
        public static string GetSubjectName()
        {
            const int MinLength = 3;

            Console.Write("Please Enter Subject Name: ");
            return GetString.GetStringValue(MinLength);
        } 
        #endregion
    }
}
