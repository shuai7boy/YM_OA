using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using YMOA_Factory;
using YMOA_IDAL;
using YMOA_Model;

namespace YMOA_Server
{
   public partial class UserInfoService
    {
       IUserInfoDal dal = DalFactory.GetUserInfo2();
       public bool Add(UserInfo user)
       {
          return  dal.Add(user)>0;
       }
       public bool Edit(UserInfo user)
       {
           return dal.Edit(user) > 0;
       }
       public bool Delete(UserInfo user)
       {
           return dal.Delete(user)>0;
       }
       public bool Delete(int id)
       {
           return dal.Delete(id) > 0;
       }
       public bool Delete(int[] ids)
       {
           return dal.Delete(ids)>0;
       }
       public IQueryable<UserInfo> Select(Expression<Func<UserInfo, bool>> selectLambda)
       {
           return dal.Select(selectLambda);
       }
       public IQueryable<UserInfo> GetPageList(Expression<Func<UserInfo, bool>> selectWhere, Expression<Func<UserInfo, int>> selectBy, int pageIndex, int pageSize)
       {
           return dal.GetPageList(selectWhere, selectBy, pageIndex, pageSize);
       }

    }
}
