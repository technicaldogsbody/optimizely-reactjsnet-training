using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Training.B.Core.Constants;

namespace Training.B.Core.DomainModels.Blocks
{
    [ContentType(
        DisplayName = BlockDisplayNames.Freetext,
        Description = BlockDescriptions.Freetext,
        GUID = Guids.FreetextBlock)]
    public class FreetextBlock : BlockData
    {
        [Display(Name = "Main body",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        [Searchable]
        [CultureSpecific]
        public virtual XhtmlString MainBody { get; set; }
    }
}
