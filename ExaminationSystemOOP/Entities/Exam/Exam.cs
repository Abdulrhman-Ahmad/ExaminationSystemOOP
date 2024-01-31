using ExaminationSystemOOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemOOP.Entities.Exam
{
    internal abstract class Exam : IExam
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

        public abstract void CreateExam();
        public abstract void ShowExam();
    }
}
