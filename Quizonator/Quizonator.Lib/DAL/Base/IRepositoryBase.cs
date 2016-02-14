using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizonator.Lib.DAL.Base
{
    public interface IRepositoryBase<T> : IDisposable where T : class
    {
        /// <summary>
        /// Get list of all T entities
        /// </summary>
        /// <returns>List of all T entities</returns>
        List<T> GetAll();
        /// <summary>
        /// Get entity of type T by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Entity of type T</returns>
        T GetByID(int id);
        /// <summary>
        /// Adds entity of type T to the database
        /// </summary>
        /// <param name="entity">Entity of type T</param>
        void Add(T entity);
        /// <summary>
        /// Delete entity of type T from the database
        /// </summary>
        /// <param name="entity">Entity of type T</param>
        void Delete(T entity);
        /// <summary>
        /// Update entity of type T in the database
        /// </summary>
        /// <param name="entity">Entity of type T</param>
        void Update(T entity);
        /// <summary>
        /// Save changes to the database
        /// </summary>
        void SaveChanges();
    }
}
