using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DLInterface;
using Model;

namespace DL
{
    public class ContractDao: IContractDao
    {
        public async Task<IList<CreditContract>> GetContracts()
        {
            return await Task.FromResult(new List<CreditContract>());
        }

        public async Task DeleteContract(int id)
        {
            await Task.FromResult(true);
        }

        public async Task UpdateContract(CreditContract contract)
        {
            await Task.FromResult(true);
        }

        public async Task<int> AddNewContract(CreditContract contract)
        {
            return await Task.FromResult(new Random().Next());
        }
    }
}
