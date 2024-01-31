using ExaminationSystemOOP.Question;
using ExaminationSystemOOP.Statics.Question;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemOOP.Entities.Exam
{
    internal class ExamPractical : Exam
    {

        #region Questions
        public List<QuestionMCQ>? MCQs { get; set; }
        #endregion

        #region Ctor
        public ExamPractical(int time, int num) : base(time, num)
        {
            MCQs = new List<QuestionMCQ>();
        }
        #endregion

        public override void CreateExam()
        {
            for (int i = 0; i < NumOfQuestions; i++)
            {
                Console.WriteLine($"Enter Question Num: {i + 1}/{NumOfQuestions}):");

                MCQs?.Add(new QuestionMCQ(
                    MCQ.GetHeader(),
                    MCQ.GetBody(),
                    MCQ.GetChoices(),
                    MCQ.GetMark()
                    ));
            }
        }
        public override void ShowExam() { }
    }
}
