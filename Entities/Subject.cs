using ExaminationSystemOOP.Entities.Exams;
using ExaminationSystemOOP.Interfaces;
using ExaminationSystemOOP.Question;
using ExaminationSystemOOP.Statics.Exams;
using ExaminationSystemOOP.Statics.Questions;

namespace ExaminationSystemOOP.Entities
{
    internal class Subject
    {

        #region Properties
        public int SubjectId;
        public string SubjectName;
        #endregion

        #region Constructor
        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }
        #endregion

        #region CreateExam
        public IExam CreateExam()
        {
            IExam exam = ExamType.GetExam(this);

            exam.CreateExam();

            return exam;
        }
        #endregion

        #region ToString Override
        public override string ToString()
        {
            return $"({SubjectId}) {SubjectName}";
        } 
        #endregion
    }
}
