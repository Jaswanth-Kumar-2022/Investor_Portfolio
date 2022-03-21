using Investors_API.IServices;
using Investors_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Investors_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MInvestorsController : ControllerBase
    {
        private readonly IMInvestorsService MInvestorsService;
        public MInvestorsController(IMInvestorsService MInvestors)
        {
            MInvestorsService = MInvestors;
        }
        [HttpGet]
        /*[Route("[action]")]
        [Route("api/FInvestors/GetFInvestors")]*/
        public IEnumerable<MaleInvestors> GetMInvestors()
        {
            return MInvestorsService.GetMInvestors();
        }
        [HttpPost]
        /*[Route("[action]")]
        [Route("api/FInvestors/AddFInvestors")]*/
        public MaleInvestors AddMInvestors(MaleInvestors Minvest)
        {
            return MInvestorsService.AddInvestors(Minvest);
        }

        [HttpPut]
        /*[Route("[action]")]
        [Route("api/FInvestors/EI")]*/
        public MaleInvestors UpdateInvestors(MaleInvestors Minvest)
        {
            return MInvestorsService.UpdateInvestors(Minvest);
        }

        [HttpDelete]
        /*[Route("[action]")]
        [Route("api/FInvestors/DI")]*/
        public MaleInvestors DeleteInvestors(int id)
        {
            return MInvestorsService.DeleteInvestors(id);
        }
    }
}
