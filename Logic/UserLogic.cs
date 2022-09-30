using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic
{
    public class UserLogic
    {

        public UserDAO userDAO = new UserDAO();
        
        public List<User> GetAllUsers()
        {
            return userDAO.GetAllUsers();
        }
    }
}
