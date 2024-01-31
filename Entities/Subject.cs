using ExaminationSystemOOP.Entities.Exams;
using ExaminationSystemOOP.Interfaces;
using ExaminationSystemOOP.Question;
using ExaminationSystemOOP.Statics.Exam;
using ExaminationSystemOOP.Statics.Question;

namespace ExaminationSystemOOP.Entities
{
    internal class Subject
    {

        public int SubjectId;
        public string SubjectName;

        public Subject(int id, string name) 
        {
            SubjectId = id;
            SubjectName = name;
        }


        public IExam CreateExam()
        {
            IExam exam =  ExamType.GetExam();

            exam.CreateExam();

            return exam;
        }

    }
}
