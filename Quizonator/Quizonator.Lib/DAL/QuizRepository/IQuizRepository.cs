using Quizonator.Lib.BLL;
using Quizonator.Lib.DAL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizonator.Lib.DAL.QuizRepository
{
    public interface IQuizRepository : IRepositoryBase<Quiz>
    {
        /// <summary>
        /// Get list of all quizes by quiz name
        /// </summary>
        /// <param name="quizName">Quiz name</param>
        /// <returns></returns>
        List<Quiz> GetAllByName(string quizName);
    }
}
