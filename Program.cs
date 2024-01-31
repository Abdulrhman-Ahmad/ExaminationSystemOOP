using ExaminationSystemOOP.Interfaces;
using ExaminationSystemOOP.Statics.Exam;
using ExaminationSystemOOP.Statics.GetConsole;

namespace ExaminationSystemOOP
{
    class Program
    {
        static void Main()
        {
            IExam exam = ExamType.GetExam();

            exam.CreateExam();
        }
    }
}