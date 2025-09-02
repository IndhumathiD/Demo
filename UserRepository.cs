using Domain.Models;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IGenericRepository<User> userRepository;
        private readonly IGenericRepository<UserProfile> userProfileRepository;

        public UserRepository(IGenericRepository<User> _userRepository, IGenericRepository<UserProfile> _userProfileRepository)
        {
            userRepository = _userRepository;
            userProfileRepository = _userProfileRepository;
        }
        public void DeleteUser(long id)
        {
            UserProfile userProfile = userProfileRepository.GetT(id);
            userProfileRepository.Remove(userProfile);
            User user = userRepository.GetT(id);
            userRepository.Remove(user);
            userRepository.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {
            return userRepository.GetAll();
        }

        public User GetUser(long id)
        {
            return userRepository.GetT(id);
        }

        public void InsertUser(User user)
        {
            userRepository.Insert(user);
        }

        public void UpdateUser(User user)
        {
            userRepository.Update(user);
        }
    }
}
