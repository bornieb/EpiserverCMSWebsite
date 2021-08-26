using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System;
using System.ComponentModel.DataAnnotations;

namespace JenniesEpiserverWebSite.Models.Blocks
{
    [ContentType(DisplayName = "Hero", GUID = "fe0d8f80-85fe-4ff1-ba2f-31c8a4d3a409", Description = "")]
    public class HeroBlock : BlockData
    {
        [Display(
            Name = "Image",
            Description = "Add an image",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        [CultureSpecific]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(
            Name = "Heading",
            Description = "Add a heading",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        [CultureSpecific]
        public virtual string Heading { get; set; }

        [Display(
            Name = "Subheading",
            Description = "Add a subheading",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [CultureSpecific]
        public virtual string SubHeading { get; set; }
    }
}