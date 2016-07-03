using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcIOC.Controllers;
using System.Web.Mvc;

namespace MvcIOC.Tests.Controllers
{
    [TestClass]
    public class ProteinTrackerControllerTest
    {
        [TestMethod]
        public void WhenNothingHasHappenedAndTotalAndGoalAreaZero()
        {
            ProteinTrackerController controller = new ProteinTrackerController();
            
            var view = controller.Index() as ViewResult;

            Assert.IsNotNull(view);
            Assert.AreEqual(0, view.ViewBag.Total);
            Assert.AreEqual(0, view.ViewBag.Goal);
        }
    }
}
