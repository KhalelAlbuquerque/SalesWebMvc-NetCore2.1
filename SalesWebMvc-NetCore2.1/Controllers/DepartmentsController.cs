using Microsoft.AspNetCore.Mvc;
using SalesWebMvc_NetCore2._1.Models;

namespace SalesWebMvc_NetCore2._1.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departments> list = new List<Departments>();

            list.Add(new Departments { Id = 1, Name = "Eletronics" });
            list.Add(new Departments { Id = 2, Name = "Fashion" });
            return View(list);
        }
    }
}
