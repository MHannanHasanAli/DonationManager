using IdentityCore.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Test.Entities;

namespace Test.Services
{
    public class DonationServices
    {
        public List<Donation> ExportDonations(DateTime start, DateTime end)
        {
            using (var context = new DBContext())
            {
                var data = context.donations.Where(c => c._ExportDate >= start && c._ExportDate <= end).ToList();
                data.Reverse();
                return data;
            }
        }
        public List<Donation> GetDonations()
        {
            using (var context = new DBContext())
            {
                var data = context.donations.ToList();
                data.Reverse();
                return data;
            }
        }

        public Donation GetDonationById(int id)
        {
            using (var context = new DBContext())
            {
                return context.donations.Find(id);
            }
        }

        public void CreateDonation(Donation Donation)
        {
            using (var context = new DBContext())
            {
                context.donations.Add(Donation);
                context.SaveChanges();
            }
        }

        public void UpdateDonation(Donation Donation)
        {
            using (var context = new DBContext())
            {
                context.donations.Update(Donation);
                context.SaveChanges();
            }
        }
        public void DeleteDonation(int id)
        {
            var data = GetDonationById(id);

            using (var context = new DBContext())
            {
                context.donations.Remove(data);
                context.SaveChanges();
            }
        }
    }
}
