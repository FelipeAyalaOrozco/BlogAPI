using BlogAPI.Models;
using BlogAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Services
{
    public class UserService
    {
        private UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserModel> GetUsers()
        {
            return _userRepository.GetUsers();
        }

        public string AddUsers(UserModel userModel)
        {

            return _userRepository.AddUsers(userModel);
        }

        public string EditUsers(int id, UserModel userModel)
        {

            return _userRepository.EditUsers(id, userModel);
        }
        public string DeleteUsers(int id)
        {

            return _userRepository.DeleteUsers(id);
        }


    }
}
