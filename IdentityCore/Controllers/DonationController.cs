using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Test.Entities;
using Test.Services;

namespace Test.Web.Controllers
{
    [Authorize]
    public class DonationController : Controller
    {
        DonationServices DonationServices = new DonationServices();
        BalanceServices BalanceServices = new BalanceServices();

        public IActionResult Index()
        {
            return View();
        }
        public JsonResult BalanceIndex()
        {
            var data = BalanceServices.GetBalances();
            return new JsonResult(data);
        }
        public JsonResult BalanceUpdate(Balance Balance)
        {
            BalanceServices.UpdateBalance(Balance);
            return new JsonResult("Record Updated");
    }
    public JsonResult DonationExport(DateTime startingDate, DateTime endingDate)
        {
            var data = DonationServices.ExportDonations(startingDate, endingDate);
            return new JsonResult(data);
        }
        public JsonResult DonationIndex()
        {
            var data = DonationServices.GetDonations();
            return new JsonResult(data);
        }

        [HttpPost]
        public JsonResult Create(Donation Donation)
        {
            Donation._Amount = Donation._Amount - Donation._Fees;   
            DonationServices.CreateDonation(Donation);
            return new JsonResult("Donation Added");

        }

        public JsonResult Delete(int id)
        {
            DonationServices.DeleteDonation(id);
            return new JsonResult("Donation Removed");
        }

        public JsonResult Edit(int id)
        {
            var data = DonationServices.GetDonationById(id);
            return new JsonResult(data);
        }
        [HttpPost]
        public JsonResult Update(Donation Donation)
        {
            DonationServices.UpdateDonation(Donation);
            return new JsonResult("Record Updated");
        }
    }
}
