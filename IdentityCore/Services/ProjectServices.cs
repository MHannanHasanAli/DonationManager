using IdentityCore.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Test.Entities;

namespace Test.Services
{
    public class ProjectServices
    {
        public List<Project> ExportProjects(DateTime start, DateTime end)
        {
            using (var context = new DBContext())
            {
                var data = context.projects.Where(c => c._ProjectInitiated >= start && c._ProjectInitiated <= end).ToList();
                data.Reverse();
                return data;
            }
        }
        public List<Project> GetProjects()
        {
            using (var context = new DBContext())
            {
                var data = context.projects.ToList();
                data.Reverse();
                return data;
            }
        }

        public Project GetProjectById(int id)
        {
            using (var context = new DBContext())
            {
                return context.projects.Find(id);
            }
        }

        public void CreateProject(Project Project)
        {
            using (var context = new DBContext())
            {
                context.projects.Add(Project);
                context.SaveChanges();
            }
        }

        public void UpdateProject(Project Project)
        {
            using (var context = new DBContext())
            {
                context.projects.Update(Project);
                context.SaveChanges();
            }
        }
        public void DeleteProject(int id)
        {
            var data = GetProjectById(id);

            using (var context = new DBContext())
            {
                context.projects.Remove(data);
                context.SaveChanges();
            }
        }
    }
}
