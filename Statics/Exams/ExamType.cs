using ExaminationSystemOOP.Entities;
using ExaminationSystemOOP.Entities.Exams;
using ExaminationSystemOOP.Interfaces;
using ExaminationSystemOOP.Statics.GetConsole;

namespace ExaminationSystemOOP.Statics.Exams
{
    internal static class ExamType
    {
        #region GetExam
        public static IExam GetExam(Subject subject)
        {
            Console.WriteLine("Choose Exam Type: \n1) Practical Exam\n2) Final Exam");

            int choose = GetNumber.GetIntegerValue(1, 2);

            #region Return Practical
            if (choose == 1)
                return new ExamPractical(
                    ExamDetails.GetExamTimeNum(),
                    ExamDetails.GetExamQuestionNum(),
                    subject
                    );
            #endregion

            #region Return Final
            return new ExamFinal(
                    ExamDetails.GetExamTimeNum(),
                    ExamDetails.GetExamQuestionNum(),
                    subject
                    ); 
            #endregion
        } 
        #endregion
    }
}
