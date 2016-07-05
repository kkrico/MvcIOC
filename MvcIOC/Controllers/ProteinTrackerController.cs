using MvcIOC.Models;
using System.Web.Mvc;

namespace MvcIOC.Controllers
{
    public class ProteinTrackerController : Controller
    {
        private IProteinTrackerService proteinTrackingService;
        //
        // GET: /ProteinTracker/

        public ProteinTrackerController(IProteinTrackerService proteinTrackingService)
        {
            this.proteinTrackingService = proteinTrackingService;
        }

        public ActionResult Index()
        {
            ViewBag.Total = proteinTrackingService.Total;
            ViewBag.Goal = proteinTrackingService.Goal;

            return View();
        }

        [HttpPost]
        public ActionResult AddProtein(int amount)
        {
            proteinTrackingService.AddProtein(amount);

            ViewBag.Total = proteinTrackingService.Total;
            ViewBag.Goal = proteinTrackingService.Goal;

            return View("Index");
        }
    }
}