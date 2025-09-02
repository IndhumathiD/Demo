using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();

        User GetUser(long id);
        void UpdateUser(User user);
        void DeleteUser(long id);
        void InsertUser(User user);
    }
}
