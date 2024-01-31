using ExaminationSystemOOP.Exam;

namespace ExaminationSystemOOP
{
    class Program
    {
        static void Main()
        {
            ExamPractical exam = new ExamPractical(60, 4);
            exam.CreateExam();
        }
    }
}