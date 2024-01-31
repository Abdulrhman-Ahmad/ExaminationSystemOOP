using ExaminationSystemOOP.Question;
using ExaminationSystemOOP.Statics.GetConsole;

namespace ExaminationSystemOOP.Statics.Exams
{
    internal static class ShowQuestions
    {
        #region Show Question
        public static int ShowQuestion(List<QuestionMCQ> mcqs, List<QuestionTF>? tfs)
        {
            #region Attributes
            int grade = 0;
            int answerId = 0; 
            #endregion

            #region Show MCQs
            foreach (var item in mcqs)
            {
                Console.WriteLine(item);
                answerId = GetNumber.GetIntegerValue(1, 4);
                if (item.CorrectAnswer.AnswerId == answerId)
                    grade += item.Mark;
            } 
            #endregion

            #region Show TFs
            if (tfs != null)
                foreach (var item in tfs)
                {
                    Console.WriteLine(item);
                    answerId = GetNumber.GetIntegerValue(1, 2);
                    if (item.CorrectAnswer.AnswerId == answerId)
                        grade += item.Mark;
                } 
            #endregion

            return grade;
        }
        #endregion
    }
}
