using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp.DataBase.RepositoryContract
{
    public interface IDataRepository<TEntity, Key> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(Key id);
        long Add(TEntity model);
        long Update(Key id, TEntity model);
        long Delete(Key id);
    }

}
