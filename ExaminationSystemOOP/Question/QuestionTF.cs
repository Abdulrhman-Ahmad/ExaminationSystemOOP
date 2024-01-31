using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemOOP.Question
{
    internal class QuestionTF : Question
    {
        #region Properties
        public Answer[] Answers = [new Answer(1, "True"), new Answer(2, "False")];
        public Answer CorrectAnswer { get; set; }
        #endregion

        #region Ctor
        public QuestionTF(string header, string body, int mark) : base(header, body, mark)
        {

        } 
        #endregion
    }
}
