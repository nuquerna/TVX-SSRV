using Model;
using System.Threading.Tasks;

namespace SLInterface
{
    internal interface IContractService
    {
        Task<int> AddNewContract(CreditContract contract);
        Task UpdateContract(CreditContract contract);
    }
}
