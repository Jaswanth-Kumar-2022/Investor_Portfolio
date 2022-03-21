using Investors_API.IServices;
using Investors_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Investors_API.Services
{
    public class MInvestorsService : IMInvestorsService
    {
        InvestorsAPIContext dbContest;
        public MInvestorsService(InvestorsAPIContext db)
        {
            dbContest = db;
        }
        public MaleInvestors AddInvestors(MaleInvestors minvestors)
        {
            dbContest.MaleInvestors.Add(minvestors);
            dbContest.SaveChanges();
            return minvestors;
        }

        public MaleInvestors DeleteInvestors(int id)
        {
            var invest = dbContest.MaleInvestors.Find(id);
            dbContest.MaleInvestors.Remove(invest);
            dbContest.SaveChanges();
            return invest;
        }

        public IEnumerable<MaleInvestors> GetMInvestors()
        {
            return dbContest.MaleInvestors.ToList();
        }

        public MaleInvestors UpdateInvestors(MaleInvestors minvestors)
        {
            dbContest.Entry(minvestors).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContest.SaveChanges();
            return minvestors;
        }
    }
}
