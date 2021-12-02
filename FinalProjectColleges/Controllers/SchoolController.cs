using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProjectColleges.Controllers
{
    public class SchoolController : Controller
    {

        private readonly ISchoolsRepository repo;

        public SchoolController(ISchoolsRepository repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var schools = repo.GetAllSchools();
            return View(schools);
        }
    }
}
