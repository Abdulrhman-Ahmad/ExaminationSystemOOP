using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemOOP.Question
{
    internal abstract class Question
    {
        #region Properties
        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }
        #endregion

        #region Ctor
        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }
        #endregion
    }
}
