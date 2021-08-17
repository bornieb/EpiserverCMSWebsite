using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace JenniesEpiserverWebSite.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "3c937149-6d04-4d88-813f-be46d7031302", Description = "")]
    public class StartPage : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
        [CultureSpecific]
        [Display(
            Name = "Header Links",
            Description = "These are the header links",
            GroupName = "Layout",
            Order = 2)]
        public virtual ContentArea HeaderLinks { get; set; }

    }
}