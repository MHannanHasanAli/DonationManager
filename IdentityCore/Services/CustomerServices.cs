using IdentityCore.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Test.Entities;

namespace Test.Services
{
    public class CustomerServices
    {
        public List<Customer> ExportCustomers(DateTime start, DateTime end)
        {
            using (var context = new DBContext())
            {
                var data = context.customers.Where(c => c._ExportDate >= start && c._ExportDate <= end).ToList();
                data.Reverse();
                return data;
            }
        }
        public List<Customer> GetCustomers()
        {
            using (var context = new DBContext())
            {
                var data = context.customers.ToList();
                data.Reverse();
                return data;
            }
        }


        public Customer GetCustomerById(int id)
        {
            using (var context = new DBContext())
            {
                return context.customers.Find(id);

            }
        }

        public void CreateCustomer(Customer Customer)
        {
            using (var context = new DBContext())
            {
                context.customers.Add(Customer);
                context.SaveChanges();
            }
        }

        public void UpdateCustomer(Customer Customer)
        {
            using (var context = new DBContext())
            {
                context.customers.Update(Customer);
                context.SaveChanges();
            }
        }
        public void DeleteCustomer(int id)
        {
            var data = GetCustomerById(id);

            using (var context = new DBContext())
            {
                context.customers.Remove(data);
                context.SaveChanges();
            }
        }
    }
}
