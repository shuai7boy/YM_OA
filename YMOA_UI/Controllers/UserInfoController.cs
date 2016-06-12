using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YMOA_Model;
using YMOA_Server;

namespace YMOA_UI.Controllers
{
    public class UserInfoController : Controller
    {
        //
        // GET: /UserInfo/
        UserInfoService user = new UserInfoService();
        public ActionResult Index()
        {  
            ViewData.Model=user.Select(u => true);
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(UserInfo recUser)
        {
            string str = "0";
            if(recUser.UserName!=null)
            { 
             bool b=user.Add(recUser);
             if (b) { str = "1"; }
            }
            return Content(str);
        }

    }
}
