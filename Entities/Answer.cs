using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemOOP.Entities
{
    internal class Answer
    {
        #region Properties
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        #endregion

        #region Ctor
        public Answer(int id, string text)
        {
            AnswerId = id;
            AnswerText = text;
        }
        #endregion

        public override string ToString()
        {
            return $"{AnswerId}){AnswerText}";
        }
    }
}
