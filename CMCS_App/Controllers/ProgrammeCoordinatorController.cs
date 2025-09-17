using Microsoft.AspNetCore.Mvc;

namespace CMCS_App.Controllers
{
    public class ProgrammeCoordinatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
