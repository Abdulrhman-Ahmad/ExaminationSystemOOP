using ExaminationSystemOOP.Entities.Exam;
using ExaminationSystemOOP.Interfaces;
using ExaminationSystemOOP.Statics.GetConsole;

namespace ExaminationSystemOOP.Statics.Exam
{
    internal static class ExamType
    {
        public static IExam GetExam()
        {
            Console.WriteLine("Choose Exam Type: \n1) Practical\n2)Final");

            int choose = GetNumber.GetIntegerValue(1, 2);

            if (choose == 1)
                return new ExamPractical(
                    ExamDetails.GetExamTimeNum(),
                    ExamDetails.GetExamQuestionNum()
                    );

            return new ExamFinal(
                ExamDetails.GetExamTimeNum(),
                ExamDetails.GetExamQuestionNum()
                );
        }



    }
}
