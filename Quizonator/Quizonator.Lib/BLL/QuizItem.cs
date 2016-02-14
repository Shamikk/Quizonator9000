using Quizonator.Lib.BLL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizonator.Lib.BLL
{
    public class QuizItem
    {
        public int QuizItemID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string HelperQuestion { get; set; }
        public User Creator { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModificationDate { get; set; }
        public QuizItemCategory Category { get; set; }

        public Quiz Quiz { get; set; }
        public List<QuizItemComment> QuizItemComments { get; set; }
    }
}
