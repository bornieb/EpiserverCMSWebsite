using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JenniesEpiserverWebSite.Models.ViewModels
{
    public class PageViewModel<T> : SiteViewModelBase where T : PageData
    {
        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }

        public T CurrentPage { get; set; }
    }
}