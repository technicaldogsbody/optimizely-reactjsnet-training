using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Training.B.Services.Contracts;

namespace Training.B.Requests.Blocks.Header
{
    public class HeaderRequestHandler : IRequestHandler<HeaderRequest, HeaderResponse>
    {
        private readonly IContentService _contentService;

        public HeaderRequestHandler(IContentService contentService)
        {
            _contentService = contentService ?? throw new ArgumentNullException(nameof(contentService));
        }

        public Task<HeaderResponse> Handle(HeaderRequest request, CancellationToken cancellationToken)
        {
            var startPage = _contentService.GetStartPage();

            var logoUrl = _contentService.GetMediaUrl(startPage.LogoReference);

            return Task.FromResult(new HeaderResponse
            {
                LogoUrl = logoUrl,
                Strapline = startPage.Strapline,
            });
        }
    }
}
