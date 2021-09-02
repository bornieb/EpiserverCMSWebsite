using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using JenniesEpiserverWebSite.Models.Pages;
using JenniesEpiserverWebSite.Models.ViewModels;

namespace JenniesEpiserverWebSite.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            var model = new PageViewModel<StartPage>(currentPage);
            model.CurrentPage = currentPage;
            model.HeaderLinks = currentPage.HeaderLinks;

            return View(model);
        }
    }
}