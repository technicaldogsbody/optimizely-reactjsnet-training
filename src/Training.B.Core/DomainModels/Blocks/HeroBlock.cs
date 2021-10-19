using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Training.B.Core.Constants;

namespace Training.B.Core.DomainModels.Blocks
{
    [ContentType(
        DisplayName = BlockDisplayNames.Hero,
        Description = BlockDescriptions.Hero,
        GUID = Guids.HeroBlock)]
    public class HeroBlock : BlockData
    {
        [Display(Name = "Heading",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [Searchable]
        [CultureSpecific]
        [Required]
        public virtual string Heading { get; set; }

        [Display(Name = "Main body",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        [Searchable]
        [CultureSpecific]
        public virtual XhtmlString MainBody { get; set; }

        [Display(Name = "Background",
            Order = 30,
            GroupName = TabNames.MediaContent)]
        [AllowedTypes(typeof(ImageData))]
        public virtual ContentReference BackgroundReference { get; set; }
    }
}
