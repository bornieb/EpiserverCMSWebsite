using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace JenniesEpiserverWebSite.Models.Blocks
{
    [ContentType(DisplayName = "ArticleBlock", GUID = "e0ae1d2f-180b-420d-8487-96ba67b4cfc9", Description = "")]
    public class ArticleBlock : BlockData
    {
        [Display(
            Name = "Heading",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        [CultureSpecific]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Text",
            Description = "Insert the text of the article.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
    }
}