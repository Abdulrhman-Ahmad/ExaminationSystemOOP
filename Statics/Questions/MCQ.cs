﻿using ExaminationSystemOOP.Entities;
using ExaminationSystemOOP.Statics.GetConsole;

namespace ExaminationSystemOOP.Statics.Questions
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
            const int MinBodyLength = 1;

            return GetString.GetStringValue(MinBodyLength);
        }
        #endregion

        #region Get Question Choices
        public static Answer[] GetChoices()
        {
            Answer[] result = new Answer[4];

            #region Fill Choices Array
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Enter Choice Num {i + 1}/4):");
                result[i] = new Answer(i + 1, Console.ReadLine() ?? "N/A");
            }
            #endregion

            return result;
        }
        #endregion

        #region Get Correct Answer
        public static Answer GetAnswer(Answer[] Choices)
        {
            Console.WriteLine("Enter the Correct AnswerId:");

            int answerId = 0;

            answerId = GetNumber.GetIntegerValue(1, 4);

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
