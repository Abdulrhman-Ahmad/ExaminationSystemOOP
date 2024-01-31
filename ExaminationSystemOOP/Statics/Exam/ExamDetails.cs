using ExaminationSystemOOP.Statics.GetConsole;

namespace ExaminationSystemOOP.Statics.Exam
{
    internal static class ExamDetails
    {
        public static int GetExamTimeNum()
        {
            const int minTime = 20;
            const int maxTime = 90;

            Console.WriteLine("Please Enter the Exam Time: ");

            return GetNumber.GetIntegerValue(minTime, maxTime);
        }

        public static int GetExamQuestionNum()
        {
            Console.WriteLine("Please Enter the Num of the Questions");

            return GetNumber.GetIntegerValue();
        }
    }
}
