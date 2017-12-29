using System.Threading.Tasks;
using DLInterface;
using Model;
using SLInterface;

namespace SL
{
    public class UserService : IUserService
    {
        private readonly IUserDao _userDao;

        public UserService(IUserDao userDao)
        {
            _userDao = userDao;
        }

        public async Task<int> AddNewUser(User user)
        {
            return await _userDao.AddNewUser(user);
        }

        public async Task UpdateUser(User user)
        {
            await _userDao.UpdateUser(user);
        }
    }
}