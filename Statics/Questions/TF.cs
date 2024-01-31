using ExaminationSystemOOP.Entities;
using ExaminationSystemOOP.Statics.GetConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemOOP.Statics.Questions
{
    internal class TF
    {
        #region Get Question Header
        public static string GetHeader()
        {
            return "True or False | Question";
        }
        #endregion

        #region Get Question Body
        public static string GetBody()
        {
            const int MinBodyLength = 1;

            return GetString.GetStringValue(MinBodyLength);
        }
        #endregion

        #region Get Correct Answer
        public static Answer GetAnswer(Answer[] Choices)
        {
            Console.WriteLine("Enter the Correct AnswerId:");

            int answerId = 0;

            answerId = GetNumber.GetIntegerValue(1, 2);

            return Choices[answerId - 1];
        }
        #endregion

        #region Get Question Mark
        public static int GetMark()
        {
            Console.WriteLine("Enter the Question Mark");

            return GetNumber.GetIntegerValue();
        }
        #endregion
    }
}
