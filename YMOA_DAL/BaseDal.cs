using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using YMOA_Model;

namespace YMOA_DAL
{
    public class BaseDal<T> where T:class,new()
    {
        DbContext db = ContextFactory.GetContext();

        //接下来实现增删该查
        //增加
        public int Add(T user)
        {         
            db.Set<T>().Add(user);
            return db.SaveChanges();
        }
        //修改
        public int Edit(T user)
        {
            db.Entry(user).State = EntityState.Modified;
            return db.SaveChanges();
        }
        //删除
        public int Delete(T user)
        {
            db.Entry(user).State = EntityState.Deleted;
            //db.Set<UserInfo>().Remove(user);
            return db.SaveChanges();
        }
        public int Delete(int id)
        {
            T user1 = db.Set<T>().Find(id);
            db.Set<T>().Remove(user1);
            return db.SaveChanges();
        }
        public int Delete(int[] ids)
        {
            int idsCount = ids.Length;
            for (int i = 0; i < ids.Length; i++)
            {
                T user1 = db.Set<T>().Find(ids[i]);
                db.Set<T>().Remove(user1);
            }
            return db.SaveChanges();
        }
        //查询
        //根据条件查询
        public IQueryable<T> Select(Expression<Func<T, bool>> selectLambda)
        {

            return db.Set<T>().Where(selectLambda);

        }
        //linq查询
        public IQueryable<T> GetPageList(Expression<Func<T, bool>> selectWhere, Expression<Func<T, int>> selectBy, int pageIndex, int pageSize)
        {
            return db.Set<T>().Where(selectWhere).OrderByDescending(selectBy).Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }
    }
}
