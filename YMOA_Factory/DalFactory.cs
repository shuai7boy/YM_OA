using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using YMOA_DAL;
using YMOA_IDAL;
using System.Data;
using System.Configuration;
namespace YMOA_Factory
{
    public partial class DalFactory
    {
        //简单工厂
        public static IUserInfoDal GetUserInfo()
        {
            return new UserInfoDal();
        }
        //抽象工厂
        public static IUserInfoDal GetUserInfo2()
        {
            //利用反射实现
            string recDll = ConfigurationManager.AppSettings["UserDll"];
            string recName = ConfigurationManager.AppSettings["CurrentName"];
            Assembly ass = Assembly.Load(recDll);
            object userInfo = ass.CreateInstance(recDll+"."+recName);
            return userInfo as IUserInfoDal;
        }
    }
}
