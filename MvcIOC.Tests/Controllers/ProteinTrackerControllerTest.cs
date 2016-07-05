using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcIOC.Controllers;
using System.Web.Mvc;
using MvcIOC.Models;

namespace MvcIOC.Tests.Controllers
{
    [TestClass]
    public class ProteinTrackerControllerTest
    {
        [TestMethod]
        public void WhenNothingHasHappenedAndTotalAndGoalAreaZero()
        {
            ProteinTrackerController controller = new ProteinTrackerController(new StubTrackingService());

            var view = controller.Index() as ViewResult;

            Assert.IsNotNull(view);
            Assert.AreEqual(0, view.ViewBag.Total);
            Assert.AreEqual(0, view.ViewBag.Goal);
        }

        [TestMethod]
        public void WhenTotalIsNonZero_AndMountAdded_TotalIsIncresead()
        {
            var service = new StubTrackingService();
            service.Total = 10;

            ProteinTrackerController controller = new ProteinTrackerController(service);

            var view = controller.AddProtein(15) as ViewResult;

            Assert.AreEqual(25, view.ViewBag.Total);
            Assert.AreEqual(0, view.ViewBag.Goal);
        }
    }

    public class StubTrackingService : IProteinTrackerService
    {
        public int Total { get; set; }
        public int Goal { get; set; }

        public void AddProtein(int amount)
        {
            Total += amount;
        }
    }
}
