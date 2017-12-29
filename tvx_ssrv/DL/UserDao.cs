using System;
using System.Threading.Tasks;
using DLInterface;
using Model;

namespace DL
{
    public class UserDao : IUserDao
    {
        public async Task<int> AddNewUser(User user)
        {
            return await Task.FromResult(new Random().Next());
        }

        public async Task UpdateUser(User user)
        {
            await Task.FromResult(true);
        }
    }
}
