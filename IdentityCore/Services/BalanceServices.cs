using IdentityCore.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Test.Entities;

namespace Test.Services
{
    public class BalanceServices
    {
        public List<Balance> GetBalances()
        {
            using (var context = new DBContext())
            {
                var data = context.balances.ToList();
                data.Reverse();
                return data;
            }
        }

        public Balance GetBalanceById(int id)
        {
            using (var context = new DBContext())
            {
                return context.balances.Find(id);
            }
        }

        public void CreateBalance(Balance Balance)
        {
            using (var context = new DBContext())
            {
                context.balances.Add(Balance);
                context.SaveChanges();
            }
        }

        public void UpdateBalance(Balance Balance)
        {
            using (var context = new DBContext())
            {  
                context.balances.Update(Balance);
                context.SaveChanges();
            }
        }
        public void DeleteBalance(int id)
        {
            var data = GetBalanceById(id);

            using (var context = new DBContext())
            {
                context.balances.Remove(data);
                context.SaveChanges();
            }
        }
    }
}
