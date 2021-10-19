using EPiServer.Core;
using EPiServer.Web;
using Training.B.Core.DomainModels.Pages;

namespace Training.B.Services.Contracts
{
    public interface IContentService
    {
        StartPage GetStartPage();

        string GetMediaUrl(ContentReference reference);

        ContextMode GetPageMode();
    }
}