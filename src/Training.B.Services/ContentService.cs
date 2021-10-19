using System;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Routing;
using Training.B.Core.DomainModels.Pages;
using Training.B.Services.Contracts;

namespace Training.B.Services
{
    public class ContentService : IContentService
    {
        private readonly IContentLoader _contentLoader;
        private readonly IUrlResolver _urlResolver;
        private readonly IContextModeResolver _contextModeResolver;

        public ContentService(IContentLoader contentLoader, IUrlResolver urlResolver, IContextModeResolver contextModeResolver)
        {
            _contentLoader = contentLoader ?? throw new ArgumentNullException(nameof(contentLoader));
            _urlResolver = urlResolver ?? throw new ArgumentNullException(nameof(urlResolver));
            _contextModeResolver = contextModeResolver ?? throw new ArgumentNullException(nameof(contextModeResolver));
        }

        public StartPage GetStartPage()
        {
            return _contentLoader.Get<StartPage>(ContentReference.StartPage);
        }

        public string GetMediaUrl(ContentReference reference)
        {
            if (!ContentReference.IsNullOrEmpty(reference))
            {
                return _urlResolver.GetUrl(reference);
            }

            return string.Empty;
        }

        public ContextMode GetPageMode()
        {
            return _contextModeResolver.CurrentMode;
        }
    }
}
