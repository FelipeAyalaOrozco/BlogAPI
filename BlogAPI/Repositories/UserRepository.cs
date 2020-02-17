using BlogAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Repositories
{
    public class UserRepository
    {
        private List<UserModel> Users = new List<UserModel>()
        {
            new UserModel {id = 1, email= "1@hotmail.com", password= "123"},
             new UserModel {id = 2, email= "2@hotmail.com.mx", password= "1234"},
              new UserModel {id = 3, email= "3@hotmail.com.mx", password= "12345"},
               new UserModel {id = 4, email= "4@hotmail.com.mx", password= "12346"}
        };


        public List<UserModel> GetUsers()
        {
            return Users;
        }
        public String AddUsers(UserModel usermodel)
        {
            Users.Add(usermodel);
            return "User added successfully";
        }
        public String EditUsers(int id, UserModel usermodel)
        {

            int i = 0, d = 0;
            foreach (UserModel s in Users)
            {
                if (s.id == id)
                {
                    d = i;
                }
                i++;
            }
            Users[d] = usermodel;

            return "User edited successfully";
        }
        public String DeleteUsers(int id)
        {
            int i = 0, d = 0;
            foreach (UserModel s in Users)
            {
                if (s.id == id)
                {
                    d = i;
                }
                i++;
            }
            Users.RemoveAt(d);
            return "User removed successfully";
        }
    }
}
