using ExaminationSystemOOP.Entities;
using ExaminationSystemOOP.Interfaces;
using ExaminationSystemOOP.Statics.Exam;
using ExaminationSystemOOP.Statics.GetConsole;

namespace ExaminationSystemOOP
{
    class Program
    {
        static void Main()
        {
            Subject subject = new Subject(1,"English");

            IExam exam = subject.CreateExam();

            exam.ShowExam();

        }
    }
}