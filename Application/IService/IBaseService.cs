using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IService
{
    public interface IBaseService<TEntity>
    {
        void Add(TEntity entity);
        IEnumerable<TEntity> GetAll();
    }
}
