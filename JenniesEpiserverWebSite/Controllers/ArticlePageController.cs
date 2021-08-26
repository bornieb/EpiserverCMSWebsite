using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using JenniesEpiserverWebSite.Models.Pages;
using JenniesEpiserverWebSite.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace JenniesEpiserverWebSite.Controllers
{
    public class ArticlePageController : PageController<ArticlePage>
    {
        private readonly IContentLoader _contentLoader;

        public ArticlePageController(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

        public ActionResult Index(ArticlePage currentPage)
        {
            var articlePageViewModel = new ArticlePageViewModel();
            articlePageViewModel.ArticlePage = currentPage;

            var startPage = _contentLoader.Get<StartPage>(ContentReference.StartPage);

            articlePageViewModel.HeaderLinks = startPage.HeaderLinks;

            return View(articlePageViewModel);
        }
    }
}