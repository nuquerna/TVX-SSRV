using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using SLInterface;

namespace tvx_ssrv.Controllers
{
    [ValidationModel]
    [Route("api/[controller]")]
    public class ContractController : Controller
    {
        private readonly IContractService _contractService;

        public ContractController(IContractService contractService)
        {
            _contractService = contractService;
        }

        [HttpGet]
        public async Task<IActionResult> GetContracts()
        {
            return Ok(await _contractService.GetContracts());
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> PostContract([FromBody]CreditContract contract)
        {
            return Ok(await _contractService.AddContract(contract));
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> PutContract([FromBody]CreditContract contract)
        {
            await _contractService.UpdateContract(contract);
            return Ok();
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteContract(int id)
        {
            await _contractService.DeleteContract(id);
            return Ok();
        }
    }
}
