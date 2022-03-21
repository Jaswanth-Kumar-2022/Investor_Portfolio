using Investors_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Investors_API.IServices
{
    public interface IMInvestorsService
    {
        IEnumerable<MaleInvestors> GetMInvestors();
        MaleInvestors AddInvestors(MaleInvestors minvestors);
        MaleInvestors UpdateInvestors(MaleInvestors minvestors);
        MaleInvestors DeleteInvestors(int id);
    }
}
