using System.Collections.Generic;
using Model;
using System.Threading.Tasks;

namespace SLInterface
{
    public interface IContractService
    {
        Task<IList<CreditContract>> GetContracts();
        Task<int> AddContract(CreditContract contract);
        Task UpdateContract(CreditContract contract);
        Task DeleteContract(int id);
    }
}
