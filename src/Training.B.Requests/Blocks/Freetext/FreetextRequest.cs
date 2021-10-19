using MediatR;
using Training.B.Core.DomainModels.Blocks;

namespace Training.B.Requests.Blocks.Freetext
{
    public record FreetextRequest : IRequest<FreetextResponse>
    {
        public FreetextBlock Block { get; }

        public FreetextRequest(FreetextBlock block)
        {
            Block = block;
        }
    }
}
