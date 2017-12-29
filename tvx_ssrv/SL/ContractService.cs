using System.Collections.Generic;
using System.Threading.Tasks;
using DLInterface;
using Model;
using SLInterface;

namespace SL
{
    public class ContractService : IContractService
    {
        private readonly IContractDao _contractDao;

        public ContractService(IContractDao contractDao)
        {
            _contractDao = contractDao;
        }

        public async Task<IList<CreditContract>> GetContracts()
        {
            return await _contractDao.GetContracts();
        }

        public async Task<int> AddContract(CreditContract contract)
        {
            return await _contractDao.AddNewContract(contract);
        }

        public async Task UpdateContract(CreditContract contract)
        {
            await _contractDao.UpdateContract(contract);
        }

        public async Task DeleteContract(int id)
        {
            await _contractDao.DeleteContract(id);
        }
    }
}
