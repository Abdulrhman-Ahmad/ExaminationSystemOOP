using ExaminationSystemOOP.Interfaces;
using ExaminationSystemOOP.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemOOP.Statics.Exams
{
    internal class ExamTotalMarks
    {
        public static int GetTotalMarks(List<QuestionMCQ> mcqs, List<QuestionTF>? tfs)
        {
            int grade = 0;

            #region Caculate MCQs Marks
            foreach (var item in mcqs)
            {
                grade += item.Mark;
            } 
            #endregion

            #region Caculate TFs Marks
            if (tfs != null)
                foreach (var item in tfs)
                {
                    grade += item.Mark;
                }
            #endregion

            return grade;
        }
    }
}
