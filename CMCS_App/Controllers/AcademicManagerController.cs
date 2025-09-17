using Microsoft.AspNetCore.Mvc;

namespace CMCS_App.Controllers
{
    public class AcademicManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
