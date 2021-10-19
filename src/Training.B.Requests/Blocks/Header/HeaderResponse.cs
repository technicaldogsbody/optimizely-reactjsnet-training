namespace Training.B.Requests.Blocks.Header
{
    public record HeaderResponse
    {
        public string LogoUrl { get; init; }
        public string Strapline { get; init; }
    }
}
