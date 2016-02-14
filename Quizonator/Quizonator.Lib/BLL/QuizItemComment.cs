using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizonator.Lib.BLL
{
    public class QuizItemComment
    {
        public int QuizCommentID { get; set; }
        public QuizItem QuizItem { get; set; }
        public string Text { get; set; }
    }
}
