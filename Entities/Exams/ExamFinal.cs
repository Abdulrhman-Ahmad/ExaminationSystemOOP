using ExaminationSystemOOP.Question;
using ExaminationSystemOOP.Statics.Exams;
using ExaminationSystemOOP.Statics.GetConsole;
using ExaminationSystemOOP.Statics.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemOOP.Entities.Exams
{
    internal class ExamFinal : Exam
    {
        #region Questions
        public List<QuestionMCQ>? MCQs;
        public List<QuestionTF>? TFs;
        #endregion

        #region Ctor
        public ExamFinal(int time, int num, Subject subject) : base(time, num, subject)
        {
            MCQs = new List<QuestionMCQ>();
            TFs  = new List<QuestionTF> ();
        }
        #endregion


        #region Show Exam
        public override void ShowExam()
        {
            ExamResult.ShowResult(MCQs, TFs, ShowQuestions.ShowQuestion(MCQs, TFs));
        } 
        #endregion

        #region Create Exam
        public override void CreateExam()
        {
            for (int i = 0; i < NumOfQuestions; i++)
            {

                Console.WriteLine("Enter Question Type\n1) MCQ Question\n2) TFs Question");
                int type = GetNumber.GetIntegerValue(1, 2);

                Console.WriteLine($"Enter Question Num: {i + 1}/{NumOfQuestions}):");

                #region Add MCQ Question
                if (type == 1)
                    MCQs?.Add(new QuestionMCQ(
                        MCQ.GetHeader(),
                        MCQ.GetBody(),
                        MCQ.GetChoices(),
                        MCQ.GetMark()
                        ));
                #endregion

                #region Add True Or False Question
                else
                    TFs?.Add(new QuestionTF(
                        TF.GetHeader(),
                        TF.GetBody(),
                        TF.GetMark()
                        )); 
                #endregion

            }
        } 
        #endregion

    }
}
