using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Business.Contracts
{
    public interface IBaseManager<TEntity, Key> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(Key id);
        long Add(TEntity model);
        long Update(Key id, TEntity model);
        long Delete(Key id);
    }
}
