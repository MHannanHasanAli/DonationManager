using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Test.Entities;
using Test.Services;

namespace Test.Web.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {
        ProjectServices ProjectServices = new ProjectServices();

        public IActionResult Index()
        {
            return View();
        }
        public JsonResult ProjectExport(DateTime startingDate, DateTime endingDate)
        {
            var data = ProjectServices.ExportProjects(startingDate, endingDate);
            return new JsonResult(data);
        }

        public JsonResult ProjectIndex()
        {
            var data = ProjectServices.GetProjects();
            return new JsonResult(data);
        }

        [HttpPost]
        public JsonResult Create(Project Project)
        {
            ProjectServices.CreateProject(Project);
            return new JsonResult("Project Added");

        }

        public JsonResult Delete(int id)
        {
            ProjectServices.DeleteProject(id);
            return new JsonResult("Project Removed");
        }

        public JsonResult Edit(int id)
        {
            var data = ProjectServices.GetProjectById(id);
            return new JsonResult(data);
        }
        [HttpPost]
        public JsonResult Update(Project Project)
        {
            ProjectServices.UpdateProject(Project);
            return new JsonResult("Record Updated");
        }
    }
}
