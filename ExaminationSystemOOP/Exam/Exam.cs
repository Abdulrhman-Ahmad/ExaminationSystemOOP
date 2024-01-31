using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemOOP.Exam
{
    internal abstract class Exam
    {
        #region Properties
        public int Time { get; set; }
        public int NumOfQuestions { get; set; }
        #endregion

        #region Ctor
        public Exam(int time, int num)
        {
            Time = time;
            NumOfQuestions = num;
        }
        #endregion


        #region Methods
        public abstract void ShowExam();
        public abstract void CreateExam(); 
        #endregion
    }
}
