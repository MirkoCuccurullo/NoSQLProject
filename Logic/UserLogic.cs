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
        public User GetUserbyUsername(string username)
        {
            return userDAO.GetUserbyUsername(username);
        }
        public void UpdatePassword(User u, Password p)
        {
            userDAO.UpdatePassword(u,p);
        }
        public bool CheckExistenceOfUserName(string username) 
        {
           return userDAO.CheckExistenceOfUserName(username);
        }
    }


}
