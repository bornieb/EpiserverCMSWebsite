using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace JenniesEpiserverWebSite.Models.Pages
{
    [ContentType(DisplayName = "StandardPage", GUID = "f16d437a-873f-4cc4-9fd4-371e83a1a766", Description = "")]
    public class StandardPage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "The page heading",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        public virtual String Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}