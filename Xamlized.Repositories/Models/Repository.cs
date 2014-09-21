using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Linq.Expressions;

namespace Xamlized.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {

        internal Table<T> DataTable;

        public Repository(DataContext dataContext)
        {
            DataTable = dataContext.GetTable<T>();
        }


        public void Insert(T entity)
        {
            DataTable.InsertOnSubmit(entity);
        }


        public void Delete(T entity)
        {
            DataTable.DeleteOnSubmit(entity);
        }

        public System.Linq.IQueryable<T> SearchFor(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
          return  DataTable.Where(predicate);
        }

        public System.Linq.IQueryable<T> GetAll()
        {
            return DataTable;
        }
    }
}
