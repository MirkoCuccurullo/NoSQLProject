using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using MongoDB.Bson;

namespace Logic
{
    public class UserLogic
    {

        public UserDAO userDAO = new UserDAO();
        
        public List<User> GetAllUsers()
        {
            return userDAO.GetAllUsers();
        }

        public User GetUserById(BsonObjectId id)
        {
            return userDAO.GetUserById(id);

        }
    }

    
}
