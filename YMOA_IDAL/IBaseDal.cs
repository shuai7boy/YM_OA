using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace YMOA_IDAL
{
    public partial interface IBaseDal<T> where T:class,new()
    {
        int Add(T t);
        int Edit(T t);
        int Delete(T t);
        int Delete(int id);
        int Delete(int[] ids);
        IQueryable<T> Select(Expression<Func<T,bool>> selectBy);
        IQueryable<T> GetPageList(Expression<Func<T, bool>> selectWhere, Expression<Func<T, int>> selectBy, int pageIndex, int pageSize);
    }
}
