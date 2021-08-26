using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace JenniesEpiserverWebSite.Models.Media
{
    [ContentType(DisplayName = "ImageFile", GUID = "09fd233d-d62e-4271-8749-f151fef8cd5b", Description = "")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,png")]
    public class ImageFile : ImageData
    {

    }
}