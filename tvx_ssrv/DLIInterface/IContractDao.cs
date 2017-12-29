using System.Collections.Generic;
using Model;
using System.Threading.Tasks;

namespace DLInterface
{
    public interface IContractDao
    {
        Task<IList<CreditContract>> GetContracts();
        Task<int> AddNewContract(CreditContract contract);
        Task UpdateContract(CreditContract contract);
        Task DeleteContract(int id);
    }
}
