using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quizonator.Lib.BLL;
using Quizonator.Lib.DAL.Base;

namespace Quizonator.Lib.DAL.QuizRepository
{
    public class QuizRepository : IQuizRepository
    {
        #region - private fields
        /// <summary>
        /// Database context
        /// </summary>
        private readonly QuizonatorDbContext _dbContext;
        /// <summary>
        /// Disposed flag
        /// </summary>
        private bool _disposed = false;
        #endregion
        #region - constructors
        /// <summary>
        /// Create QuizRepository object passing reference to the database context
        /// </summary>
        /// <param name="dbContext"></param>
        public QuizRepository(QuizonatorDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region - public methods
        #region - implementing IQuizRepository
        /// <summary>
        /// Add Quiz to the database.
        /// </summary>
        /// <param name="entity">Quiz entity</param>
        public void Add(Quiz entity)
        {
            _dbContext.Quizes.Add(entity);
        }
        /// <summary>
        /// Delete Quiz from the database.
        /// </summary>
        /// <param name="entity">Quiz entity</param>
        public void Delete(Quiz entity)
        {
            _dbContext.Quizes.Remove(entity);
        }
        /// <summary>
        /// Get all quizes from the database.
        /// </summary>
        /// <returns></returns>
        public List<Quiz> GetAll()
        {
            return _dbContext.Quizes.ToList();
        }
        /// <summary>
        /// Get all quizes by name.
        /// </summary>
        /// <param name="quizName">Quiz name</param>
        /// <returns></returns>
        public List<Quiz> GetAllByName(string quizName)
        {
            return _dbContext.Quizes.Where(x => x.Name == quizName).ToList();
        }
        /// <summary>
        /// Get quiz by id.
        /// </summary>
        /// <param name="id">Quiz id</param>
        /// <returns></returns>
        public Quiz GetByID(int id)
        {
            return _dbContext.Quizes.Where(x => x.QuizID == id).SingleOrDefault();
        }
        /// <summary>
        /// Update quiz in the database.
        /// </summary>
        /// <param name="entity">Quiz entity</param>
        public void Update(Quiz entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
        /// <summary>
        /// Save changes to the database.
        /// </summary>
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
        #endregion
        #region - implementing IDisposable
        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
        #endregion
    }
}
