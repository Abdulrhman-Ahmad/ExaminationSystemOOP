using ExaminationSystemOOP.Interfaces;
using ExaminationSystemOOP.Question;
using ExaminationSystemOOP.Statics.Question;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public override void ShowExam()
        {
            Console.Clear();
            Console.WriteLine($"Exam To {Subject}");
            Console.WriteLine("----------------------------");
            for(int i = 0; i < NumOfQuestions; i++)
            {
                Console.WriteLine($"Q{i+1}) " + MCQs[i]);
            }


            Console.ReadKey();
        }
    }
}
