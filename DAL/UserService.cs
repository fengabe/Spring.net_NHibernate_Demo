using System;
using System.Collections.Generic;
using System.Text;
using Spring.Data.NHibernate.Generic.Support;
using Model;
using IDAL;

namespace DAL
{
    public class UserService : BaseDAL<Users>, IUserService
    {
       
        
       public Users GetUserByLoginNameAndPwd(string name, string pwd)
       { 
            
         return this.Session.CreateQuery("from Users u where u.LoginId=:id and u.LoginPwd =:pwd")
             .SetString("id", name).SetString("pwd",pwd)
              .UniqueResult<Users>();
           
          
       }

    }
}
