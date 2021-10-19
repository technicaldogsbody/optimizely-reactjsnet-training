using EPiServer.Core;
using Training.B.Core.DomainModels.Blocks;

namespace Training.B.Requests.Pages.StartPage
{
    public record StartPageResponse
    {
        public HeroBlock Hero { get; init; }
        public string HeroName { get; init; }
        public string IntroTitle { get; init; }
        public string IntroTitleName { get; init; }
        public string IntroTextName { get; init; }
        public string IntroText { get; init; }
        public ContentArea ContentArea { get; init; }
        public string ContentAreaName { get; init; }
    }
}
