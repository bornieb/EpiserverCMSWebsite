using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace JenniesEpiserverWebSite.Models.Pages
{
    [ContentType(DisplayName = "ArticlePage", GUID = "feed7e00-483d-49f6-ae14-1af490366662", Description = "")]
    public class ArticlePage : PageData
    {
        [CultureSpecific]
        [Display(
           Name = "Main body",
           Description = "Insert article block",
           GroupName = SystemTabNames.Content,
           Order = 2)]
        public virtual ContentArea MainContentArea { get; set; }
    }
}