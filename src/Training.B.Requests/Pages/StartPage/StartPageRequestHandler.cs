using System;
using System.Threading;
using System.Threading.Tasks;
using EPiServer.Web;
using MediatR;
using Training.B.Services.Contracts;

namespace Training.B.Requests.Pages.StartPage
{
    public class StartPageRequestHandler :IRequestHandler<StartPageRequest, StartPageResponse>
    {
        private readonly IContentService _contentService;

        public StartPageRequestHandler(IContentService contentService)
        {
            _contentService = contentService ?? throw new ArgumentNullException(nameof(contentService));
        }

        public async Task<StartPageResponse> Handle(StartPageRequest request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new StartPageResponse
            {
                Hero = request.StartPage.HeroBlock,
                HeroName = nameof(request.StartPage.HeroBlock),
                IntroTitle = request.StartPage.IntroTitle,
                IntroTitleName = nameof(request.StartPage.IntroTitle),
                IntroText = _contentService.GetPageMode() == ContextMode.Edit
                    ? request.StartPage.IntroText?.ToEditString()
                    : request.StartPage.IntroText?.ToHtmlString(),
                IntroTextName = nameof(request.StartPage.IntroText),
                ContentArea = request.StartPage.MainContentArea,
                ContentAreaName = nameof(request.StartPage.MainContentArea)
            });
        }
    }
}
