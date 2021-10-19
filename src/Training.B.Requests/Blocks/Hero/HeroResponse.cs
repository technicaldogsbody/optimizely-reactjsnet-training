namespace Training.B.Requests.Blocks.Hero
{
    public record HeroResponse
    {
        public string Heading { get; init; }
        public string HeadingName { get; init; }
        public string Body { get; init; }
        public string BodyName { get; init; }
        public string BackgroundUrl { get; init; }
        public string BackgroundName { get; init; }
    }
}
