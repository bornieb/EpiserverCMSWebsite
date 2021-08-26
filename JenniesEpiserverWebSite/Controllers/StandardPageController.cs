using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using JenniesEpiserverWebSite.Models.Pages;
using JenniesEpiserverWebSite.Models.ViewModels;
using EPiServer.ServiceLocation;

namespace JenniesEpiserverWebSite.Controllers
{
    public class StandardPageController : PageController<StandardPage>
    {
        private readonly IContentLoader _contentLoader;

        public StandardPageController(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

        public ActionResult Index(StandardPage currentPage)
        {
            var standardPageViewModel = new StandardPageViewModel();
            standardPageViewModel.StandardPage = currentPage;

            var startPage = _contentLoader.Get<StartPage>(ContentReference.StartPage);

            standardPageViewModel.HeaderLinks = startPage.HeaderLinks;

            return View(standardPageViewModel);
        }
    }
}