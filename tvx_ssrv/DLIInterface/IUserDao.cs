using System.Threading.Tasks;
using Model;

namespace DLInterface
{
    public interface IUserDao
    {
        Task<int> AddNewUser(User user);
        Task UpdateUser(User user);
    }
}
