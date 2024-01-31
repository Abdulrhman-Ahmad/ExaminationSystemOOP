using ExaminationSystemOOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemOOP.Entities.Exams
{
    internal abstract class Exam : IExam
    {
        #region Properties
        public int Time;
        public int NumOfQuestions;
        public Subject Subject;
        #endregion

        #region Ctor
        public Exam(int time, int num, Subject subject)
        {
            Time = time;
            NumOfQuestions = num;
            Subject = subject;
        }
        #endregion

        #region Abstract Methods
        public abstract void ShowExam();
        public abstract void CreateExam(); 
        #endregion
    }
}
