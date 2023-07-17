using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Test.Entities;
using Test.Services;

namespace Test.Web.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        CustomerServices CustomerServices = new CustomerServices();

        public IActionResult Index()
        {
            return View();
        }


        public JsonResult CustomerIndex()
        {
            var data = CustomerServices.GetCustomers();
            return new JsonResult(data);
        }
        public JsonResult CustomerExport(DateTime startingDate, DateTime endingDate)
        {
            var data = CustomerServices.ExportCustomers(startingDate, endingDate);
            return new JsonResult(data);
        }
        [HttpPost]
        public JsonResult Create(Customer Customer)
        {
            CustomerServices.CreateCustomer(Customer);
            return new JsonResult("Customer Added");

        }

        public JsonResult Delete(int id)
        {
            CustomerServices.DeleteCustomer(id);
            return new JsonResult("Customer Removed");
        }

        public JsonResult Edit(int id)
        {
            var data = CustomerServices.GetCustomerById(id);
            return new JsonResult(data);
        }
        [HttpPost]
        public JsonResult Update(Customer Customer)
        {
            CustomerServices.UpdateCustomer(Customer);
            return new JsonResult("Record Updated");
        }
    }
}
