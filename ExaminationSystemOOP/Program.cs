using ExaminationSystemOOP.Entities.Exam;
using ExaminationSystemOOP.Interfaces;
using ExaminationSystemOOP.Statics.GetConsole;
using ExaminationSystemOOP.Statics.Exam;

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