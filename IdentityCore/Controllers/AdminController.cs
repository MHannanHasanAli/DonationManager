using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Test.Services;

namespace Test.Web.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        ProjectServices ProjectServices = new ProjectServices();
        DonationServices DonationServices = new DonationServices();
        CustomerServices CustomerServices = new CustomerServices();
        BalanceServices BalanceServices = new BalanceServices();
        public IActionResult Dashboard()
        {
            return View();
        }
        public JsonResult DashboardBalanceIndex()
        {
            var data = BalanceServices.GetBalances();
            return new JsonResult(data);
        }
        public JsonResult DashboardProjectIndex()
        {
            var data = ProjectServices.GetProjects();
            return new JsonResult(data);
        }
        public JsonResult DashboardCustomerIndex()
        {
            var data = CustomerServices.GetCustomers();
            return new JsonResult(data);
        }
        public JsonResult DashboardDonationIndex()
        {
            var data = DonationServices.GetDonations();
            return new JsonResult(data);
        }
    }
}
