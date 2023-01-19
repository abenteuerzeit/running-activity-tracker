using RunningActivityTracker.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RunningActivityTracker.Services
{
    internal class UserService : IUserService
    {
        public Task<UserEntity> AuthenticateAsync(string userName, string password)
        {
            throw new System.NotImplementedException();
        }

        public void CreateUser(UserEntity user)
        {
            throw new System.NotImplementedException();
        }

        public UserEntity FindCurrentUser()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UserEntity> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}