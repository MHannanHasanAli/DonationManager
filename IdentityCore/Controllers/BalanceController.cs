using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Test.Entities;
using Test.Services;

namespace Test.Web.Controllers
{
    [Authorize]
    public class BalanceController : Controller
    {
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

        [HttpPost]
        public JsonResult Create(Balance Balance)
        {
            BalanceServices.CreateBalance(Balance);
            return new JsonResult("Balance Added");

        }

        public JsonResult Delete(int DeleteAmount)
        {
            BalanceServices.DeleteBalance(DeleteAmount);
            return new JsonResult("Balance Removed");
        }

        public JsonResult Edit(int id)
        {
            var data = BalanceServices.GetBalanceById(id);
            return new JsonResult(data);
        }
        [HttpPost]
        public JsonResult Update(Balance Balance)
        {
            BalanceServices.UpdateBalance(Balance);
            return new JsonResult("Record Updated");
        }
    }
}
