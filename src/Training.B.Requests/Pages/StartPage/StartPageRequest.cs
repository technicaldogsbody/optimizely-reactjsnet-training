using MediatR;

namespace Training.B.Requests.Pages.StartPage
{
    public record StartPageRequest : IRequest<StartPageResponse>
    {
        public Core.DomainModels.Pages.StartPage StartPage { get; }

        public StartPageRequest(Core.DomainModels.Pages.StartPage startPage)
        {
            StartPage = startPage;
        }
    }
}
