using ExaminationSystemOOP.Question;
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
        public List<QuestionTF>? TrueOrFalse;
        #endregion

        #region Ctor
        public ExamFinal(int time, int num) : base(time, num)
        {
            MCQs = new List<QuestionMCQ>();
            TrueOrFalse = new List<QuestionTF>();
        }
        #endregion


        public override void ShowExam() { }
        public override void CreateExam() { }

    }
}
