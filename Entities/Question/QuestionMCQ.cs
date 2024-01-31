using ExaminationSystemOOP.Entities;
using ExaminationSystemOOP.Statics.Question;
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

        
    }
}
