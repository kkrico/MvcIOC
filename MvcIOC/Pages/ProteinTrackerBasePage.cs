using Microsoft.Practices.Unity;
using MvcIOC.Models;
using System;
using System.Web.Mvc;

namespace MvcIOC.Pages
{
    public class ProteinTrackerBasePage: WebViewPage
    {
        [Dependency]
        public IAnalyticService AnalyticService { get; set; }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}