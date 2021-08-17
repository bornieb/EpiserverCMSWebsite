using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JenniesEpiserverWebSite.Models.ViewModels
{
    public abstract class SiteViewModelBase
    {
        public ContentArea HeaderLinks { get; set; }
    }
}