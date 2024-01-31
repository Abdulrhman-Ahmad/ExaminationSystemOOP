using ExaminationSystemOOP.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemOOP.Entities.Exam
{
    internal class ExamFinal : Exam
    {
        #region Questions
        public List<QuestionMCQ>? MCQs { get; set; }
        public List<QuestionTF>? TrueOrFalse { get; set; }
        #endregion

        #region Ctor
        public ExamFinal(int time, int num) : base(time, num)
        {
        }
        #endregion

        public override void CreateExam() { }

        public override void ShowExam() { }
    }
}
