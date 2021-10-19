using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using Training.B.Core.Constants;
using Training.B.Core.DomainModels.Blocks;
using Training.B.Core.DomainModels.Media;

namespace Training.B.Core.DomainModels.Pages
{
    [ContentType(
        GUID = Guids.StartPage,
        DisplayName = PageDisplayNames.StartPage,
        Description = PageDescriptions.StartPage)]
    public class StartPage : PageData
    {

        [Display(Name = "Logo",
            Order = 30,
            GroupName = TabNames.HeaderContent)]
        [AllowedTypes(typeof(ImageFile))]
        public virtual ContentReference LogoReference { get; set; }

        [Display(Name = "Strapline",
            Order = 30,
            GroupName = TabNames.HeaderContent)]
        public virtual string Strapline { get; set; }

        [Display(Name = "Hero",
            Order = 10,
            GroupName = SystemTabNames.Content)]
        public virtual HeroBlock HeroBlock { get; set; }

        [Display(Name = "Intro Title",
            Order = 20,
            GroupName = SystemTabNames.Content)]
        public virtual string IntroTitle { get; set; }

        [Display(Name = "Intro Text",
            Order = 30,
            GroupName = SystemTabNames.Content)]
        public virtual XhtmlString IntroText { get; set; }

        [Display(Name = "Main Content Area",
            Order = 40,
            GroupName = SystemTabNames.Content)]
        [AllowedTypes(typeof(HeroBlock), typeof(FreetextBlock))]
        public virtual ContentArea MainContentArea { get; set; }
    }
}