using System;
using System.Collections.Generic;
using DL;
using Models;

namespace BL
{
    public class UsersBL : IUserBL
    {
        IUserRepo _repo;

        public UsersBL(IUserRepo p_repo)
        {
            _repo=p_repo;
        }
        public Users AddUser(Users p_user)
        {
            return _repo.AddUser(p_user);
        }

        public List<Users> GetAllUsers()
        {
            return _repo.GetAllUsers();
        }
        
    }
}
