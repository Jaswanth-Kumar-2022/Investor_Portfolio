using Lib.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Service.InvestorService
{
    public interface IInvestorService
    {
        Task<List<Investor>> GetInvestor();
        Task<bool> SaveInvestor(Investor model);
    }
}
