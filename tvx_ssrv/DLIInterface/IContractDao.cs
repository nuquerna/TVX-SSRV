using Model;
using System.Threading.Tasks;

namespace DLIInterface
{
    internal interface IContractDao
    {
        Task<int> AddNewContract(CreditContract contract);
        Task UpdateContract(CreditContract contract);
    }
}
