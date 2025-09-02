using Domain.Models;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly IGenericRepository<UserProfile> userProfileRepository;

        public UserProfileRepository(IGenericRepository<UserProfile> _userProfileRepository)
        {
            userProfileRepository = _userProfileRepository;
        }
        public UserProfile GetUserProfile(long id)
        {
            return userProfileRepository.GetT(id);
        }
    }
}
