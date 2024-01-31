using ExaminationSystemOOP.Entities;
using ExaminationSystemOOP.Statics.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemOOP.Question
{
    internal class QuestionMCQ : Question
    {
        #region Properties
        public Answer[] Answers;
        public Answer CorrectAnswer;
        #endregion

        #region Ctor
        public QuestionMCQ(string header, string body, Answer[] answers, int mark) : base(header, body, mark)
        {
            CorrectAnswer = MCQ.GetAnswer(answers);
            Answers = answers;
        }
        #endregion

        #region ToString Override
        public override string ToString()
        {
            return $"{Body}\n{Answers[0]}  \n{Answers[1]}  \n{Answers[2]}  \n{Answers[3]}";
        } 
        #endregion
    }
}
