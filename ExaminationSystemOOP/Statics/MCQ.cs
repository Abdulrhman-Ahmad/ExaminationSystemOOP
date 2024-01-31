using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemOOP.Statics
{
    internal static class MCQ
    {

        #region Get Question Header
        public static string GetHeader()
        {
            return "MCQ | Question";
        }
        #endregion

        #region Get Question Body
        public static string GetBody()
        {
            return Console.ReadLine()?.ToString() ?? "";
        }
        #endregion

        #region Get Question Choices
        public static Answer[] GetChoices()
        {
            Answer[] result = new Answer[4];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Enter Choice Num {i + 1}/4):");
                result[i] = new Answer(i + 1, Console.ReadLine() ?? "N/A");
            }


            return result;
        }

        #endregion

        #region Get Correct Answer
        public static Answer GetAnswer(Answer[] Choices)
        {
            Console.WriteLine("Enter the Correct AnswerId:");
            int answerId = Convert.ToInt32(Console.ReadLine());
            return Choices[answerId];
        }
        #endregion

        #region Get Question Mark
        public static int GetMark()
        {
            Console.ReadLine("Enter the Question Mark");
            return Convert.ToInt32(Console.ReadLine());
        }
        #endregion
    }
}
