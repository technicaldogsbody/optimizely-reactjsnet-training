using System;
using System.Threading;
using System.Threading.Tasks;
using EPiServer.Web;
using MediatR;
using Training.B.Services.Contracts;

namespace Training.B.Requests.Blocks.Hero
{
    public class HeroRequestHandler : IRequestHandler<HeroRequest, HeroResponse>
    {
        private readonly IContentService _contentService;

        public HeroRequestHandler(IContentService contentService)
        {
            _contentService = contentService ?? throw new ArgumentNullException(nameof(contentService));
        }

        public async Task<HeroResponse> Handle(HeroRequest request, CancellationToken cancellationToken)
        {
            if (request.Block == null)
            {
                throw new ArgumentNullException(nameof(request.Block));
            }

            return await Task.FromResult(new HeroResponse
            {
                Heading = request.Block.Heading,
                HeadingName = nameof(request.Block.Heading),
                Body = _contentService.GetPageMode() == ContextMode.Edit
                    ? request.Block.MainBody?.ToEditString()
                    : request.Block.MainBody?.ToHtmlString(),
                BodyName = nameof(request.Block.MainBody),
                BackgroundUrl = _contentService.GetMediaUrl(request.Block.BackgroundReference),
                BackgroundName = nameof(request.Block.BackgroundReference)
            });
        }
    }
}
