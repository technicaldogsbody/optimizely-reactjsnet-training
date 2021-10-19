using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using Training.B.Core.Constants;

namespace Training.B.Core.DomainModels.Media
{
    [ContentType(DisplayName = "Image", GUID = Guids.ImageFile)]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png,svg")]
    public class ImageFile : ImageData
    {

    }
}
