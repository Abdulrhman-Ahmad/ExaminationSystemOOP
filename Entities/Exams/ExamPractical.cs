using ExaminationSystemOOP.Question;
using ExaminationSystemOOP.Statics.Exams;
using ExaminationSystemOOP.Statics.Questions;

namespace ExaminationSystemOOP.Entities.Exams
{
    internal class ExamPractical : Exam
    {

        #region Questions
        public List<QuestionMCQ> MCQs;
        #endregion

        #region Ctor
        public ExamPractical(int time, int num, Subject subject) : base(time, num, subject)
        {
            MCQs = new List<QuestionMCQ>();
        }
        #endregion

        #region CreateExam
        public override void CreateExam()
        {
            for (int i = 0; i < NumOfQuestions; i++)
            {
                Console.WriteLine($"Enter Question Num: {i + 1}/{NumOfQuestions}):");

                #region Add MCQ Questions
                MCQs?.Add(new QuestionMCQ(
                    MCQ.GetHeader(),
                    MCQ.GetBody(),
                    MCQ.GetChoices(),
                    MCQ.GetMark()
                    )); 
                #endregion
            }
        }
        #endregion

        #region ShowExam
        public override void ShowExam()
        {
            ExamResult.ShowResult(MCQs, null,ShowQuestions.ShowQuestion(MCQs, null));
        } 
        #endregion
    }
}
