using ExaminationSystemOOP.Statics.GetConsole;

namespace ExaminationSystemOOP.Statics.Exams
{
    internal static class ExamDetails
    {
        #region GetExamTime
        public static int GetExamTimeNum()
        {
            const int minTime = 20;
            const int maxTime = 90;

            Console.Write("Please Enter the Exam Time: ");

            return GetNumber.GetIntegerValue(minTime, maxTime);
        }
        #endregion

        #region GetExamQuestionNum
        public static int GetExamQuestionNum()
        {
            Console.Write("Please Enter the Num of the Questions: ");

            return GetNumber.GetIntegerValue();
        } 
        #endregion
    }
}
