using System.Collections.Generic;
using BL;
using Models;

namespace UI
{
    public class ConsoleTesting
    {
        IUserBL _userBL;

        public ConsoleTesting(IUserBL p_userBL)
        {
            _userBL=p_userBL;
        }

        public  Users TestAdd()
        {
            return _userBL.AddUser( new Users()
            {
                UserName = "name",
                UserPass = "password",
                Email = "mail@mail.com"
            });
        }

        public List<Users> TestShowAll()
        {
            return _userBL.GetAllUsers();
        }
    }
}