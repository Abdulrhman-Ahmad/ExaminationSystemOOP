using ExaminationSystemOOP.Entities;
using ExaminationSystemOOP.Interfaces;
using ExaminationSystemOOP.Statics.GetSubject;

namespace ExaminationSystemOOP
{
    class Program
    {
        static void Main()
        {
            Subject subject = GetSubject.GetSubjectValue();

            IExam exam = subject.CreateExam();

            exam.ShowExam();
        }
    }
}