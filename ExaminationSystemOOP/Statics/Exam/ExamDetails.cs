using ExaminationSystemOOP.Statics.GetConsole;

namespace ExaminationSystemOOP.Statics.Exam
{
    internal static class ExamDetails
    {
        public static int GetExamTimeNum()
        {
            Console.WriteLine("Please Enter the Exam Time: ");

            return GetNumber.GetIntegerValue();
        }

        public static int GetExamQuestionNum()
        {
            Console.WriteLine("Please Enter the Num of the Questions");

            return GetNumber.GetIntegerValue();
        }
    }
}
