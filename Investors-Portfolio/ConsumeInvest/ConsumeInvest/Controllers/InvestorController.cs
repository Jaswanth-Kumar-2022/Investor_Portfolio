using Lib.Core.Model;
using Lib.Service.InvestorService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeInvest.Controllers
{
    public class InvestorController : Controller
    {
        private readonly IInvestorService investorService;
        public InvestorController(IInvestorService investServices)
        {
            investorService = investServices;
        }
        public async Task<IActionResult> List()
        {
            var list = await investorService.GetInvestor();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Investor model)
        {
            if (ModelState.IsValid)
            {
                bool response = await investorService.SaveInvestor(model);
                if (response)
                {
                    return RedirectToAction("List");
                }
            }
            return View(model);
        }

    }
}
