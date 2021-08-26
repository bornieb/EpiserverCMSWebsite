using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using JenniesEpiserverWebSite.Models.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JenniesEpiserverWebSite.Controllers
{
    public class HeroBlockController : BlockController<HeroBlock>
    {
        public override ActionResult Index(HeroBlock currentBlock)
        {
            return PartialView("~/Views/Shared/Blocks/HeroBlock.cshtml", currentBlock);
        }
    }
}
