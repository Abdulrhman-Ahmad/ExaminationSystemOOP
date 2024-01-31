using ExaminationSystemOOP.Question;

namespace ExaminationSystemOOP.Statics.Exams
{
    internal class ExamResult
    {
        public static void ShowResult(List<QuestionMCQ>? mcqs, List<QuestionTF>? tfs, int grade)
        {
            #region Show MCQs
            foreach (var item in mcqs)
            {
                Console.WriteLine($"{item}  \nCorrect Answer -> ({item.CorrectAnswer}\n");
            } 
            #endregion

            #region Show TFs
            if (tfs != null)
                foreach (var item in tfs)
                {
                    Console.WriteLine($"{item}  \nCorrect Answer -> ({item.CorrectAnswer}\n");
                }
            #endregion

            int totalGrade = ExamTotalMarks.GetTotalMarks(mcqs, tfs);

            Console.WriteLine($"\nYour Grade is {grade}/{totalGrade}");
        }
    }
}
