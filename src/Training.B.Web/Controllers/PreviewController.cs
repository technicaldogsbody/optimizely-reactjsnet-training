using System.Diagnostics.CodeAnalysis;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Training.B.Web.Controllers
{
    [TemplateDescriptor(
        Inherited = true,
        TemplateTypeCategory = TemplateTypeCategories.MvcController, //Required as controllers for blocks are registered as MvcPartialController by default
        Tags = new[] { RenderingTags.Preview, RenderingTags.Edit },
        AvailableWithoutTag = false)]
    [ExcludeFromCodeCoverage]
    public class PreviewController : ActionControllerBase, IRenderTemplate<BlockData>
    {
        public ActionResult Index(BlockData currentContent)
        {
            return View("_Preview", currentContent);
        }

    }
}
