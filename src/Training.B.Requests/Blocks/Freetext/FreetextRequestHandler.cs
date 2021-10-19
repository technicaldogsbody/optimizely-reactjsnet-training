using System;
using System.Threading;
using System.Threading.Tasks;
using EPiServer.Web;
using MediatR;
using Training.B.Services.Contracts;

namespace Training.B.Requests.Blocks.Freetext
{
    public class FreetextRequestHandler : IRequestHandler<FreetextRequest, FreetextResponse>
    {
        private readonly IContentService _contentService;

        public FreetextRequestHandler(IContentService contentService)
        {
            _contentService = contentService ?? throw new ArgumentNullException(nameof(contentService));
        }

        public async Task<FreetextResponse> Handle(FreetextRequest request, CancellationToken cancellationToken)
        {
            if (request.Block == null)
            {
                throw new ArgumentNullException(nameof(request.Block));
            }

            return await Task.FromResult(new FreetextResponse
            {
                Body = _contentService.GetPageMode() == ContextMode.Edit
                    ? request.Block.MainBody.ToEditString()
                    : request.Block.MainBody.ToHtmlString(),
                BodyName = nameof(request.Block.MainBody),
            });
        }
    }
}
