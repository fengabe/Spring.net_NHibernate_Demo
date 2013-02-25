using System;
using System.Collections.Generic;
using System.Text;
using Model;


namespace IDAL
{
    public interface IUserService:IBaseDAL<Users>
    {
         Users GetUserByLoginNameAndPwd(string name, string pwd);
    }
}
