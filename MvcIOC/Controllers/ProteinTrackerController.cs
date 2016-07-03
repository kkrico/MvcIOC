using MvcIOC.Models;
using System.Web.Mvc;

namespace MvcIOC.Controllers
{
    public class ProteinTrackerController : Controller
    {
        private IProteinTrackerService proteinTrackingService;
        //
        // GET: /ProteinTracker/

        public ProteinTrackerController(IProteinTrackerService proteinTrackerService)
        {
            proteinTrackerService = proteinTrackingService;
        }

        public ActionResult Index()
        {
            ViewBag.Total = proteinTrackingService.Total;
            ViewBag.Goal = proteinTrackingService.Goal;

            return View();
        }

        [HttpPost]
        public ActionResult AddProtein(string amount)
        {
            proteinTrackingService.AddProtein(int.Parse(amount));

            ViewBag.Total = proteinTrackingService.Total;
            ViewBag.Goal = proteinTrackingService.Goal;

            return View("Index");
        }
    }
}