using ExaminationSystemOOP.Entities;
using ExaminationSystemOOP.Statics.Questions;

namespace ExaminationSystemOOP.Question
{
    internal class QuestionTF : Question
    {
        #region Properties
        public Answer[] Answers = [new Answer(1, "True"), new Answer(2, "False")];
        public Answer CorrectAnswer;
        #endregion

        #region Ctor
        public QuestionTF(string header, string body, int mark) : base(header, body, mark)
        {
            CorrectAnswer = TF.GetAnswer(Answers);
        }
        #endregion

        #region ToString Override
        public override string ToString()
        {
            return $"{Body}\t(Mark {Mark})\n{Answers[0]}\n{Answers[1]}";
        } 
        #endregion
    }
}
