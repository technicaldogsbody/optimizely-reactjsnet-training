using MediatR;
using Training.B.Core.DomainModels.Blocks;

namespace Training.B.Requests.Blocks.Hero
{
    public record HeroRequest : IRequest<HeroResponse>
    {
        public HeroBlock Block { get; }

        public HeroRequest(HeroBlock block)
        {
            Block = block;
        }
    }
}
