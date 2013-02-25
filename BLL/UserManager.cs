using System;
using System.Collections.Generic;
using System.Text;

using Model;
using IDAL;

namespace BLL
{
    public class UserManager
    {

        protected IUserService _userService;

        public IUserService UserService
        {
            get { return _userService; }
            set { _userService = value; }
        }


        public Users Login(string name, string pwd)
        {
           return  _userService.GetUserByLoginNameAndPwd(name,pwd);
        }

    }
}
