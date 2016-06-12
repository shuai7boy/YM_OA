using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using YMOA_Model;

namespace YMOA_DAL
{
    public partial  class ContextFactory
    {      
        public static DbContext GetContext()
        {
            DbContext db = CallContext.GetData("context") as DbContext;  
            if(db==null)
            {
                db = new YM_OAContainer();
                CallContext.SetData("context", db);
            }
            return db;
        }
    }
}
