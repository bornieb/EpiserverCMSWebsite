using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System;
using System.ComponentModel.DataAnnotations;

namespace JenniesEpiserverWebSite.Models.Blocks
{
    [ContentType(DisplayName = "TeaserBlock", GUID = "ab8ea490-6f35-4b1a-9ae4-c8d4f5fc63d2", Description = "")]
    public class TeaserBlock : BlockData
    {
        [Display(
            Name = "Heading",
            GroupName = SystemTabNames.Content,
            Order = 1)] 
        [CultureSpecific]
        public virtual string Heading { get; set; }

        [Display(
            Name = "Subheading",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [CultureSpecific]
        public virtual string Subheading { get; set; }

        [Display(
            Name = "Image",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        [CultureSpecific]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(
            Name = "Pagelink",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual PageReference Link { get; set; }
    }
}