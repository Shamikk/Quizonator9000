using Quizonator.Lib.DAL.QuizRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizonator.Lib.BLL
{
    public class Quiz
    {
        #region - private fields
        #endregion
        #region - public properties
        public int QuizID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModificationDate { get; set; }
        #endregion

        #region - navigation properties
        public User Creator { get; set; }
        public List<User> Attenders { get; set; }
        public List<QuizItem> QuizItems { get; set; }
        #endregion

        #region - constructors
        public Quiz()
        {

        }
        #endregion

        #region - public methods
        public void Create()
        {

        }
        public void Update()
        {

        }
        #endregion
    }
}
