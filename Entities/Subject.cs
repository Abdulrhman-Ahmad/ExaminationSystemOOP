using ExaminationSystemOOP.Entities.Exams;
using ExaminationSystemOOP.Interfaces;
using ExaminationSystemOOP.Question;
using ExaminationSystemOOP.Statics.Exams;
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
            IExam exam =  ExamType.GetExam(this);

            exam.CreateExam();

            return exam;
        }

        public override string ToString()
        {
            return $"({SubjectId}) {SubjectName}";
        }
    }
}
