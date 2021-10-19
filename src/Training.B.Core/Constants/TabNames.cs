using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace Training.B.Core.Constants
{
    [GroupDefinitions]
    public static class TabNames
    {
        [Display(GroupName = "Media", Order = 10)]
        public const string MediaContent = "Media";

        [Display(GroupName = "Header", Order = 900)]
        public const string HeaderContent = "Header";
    }
}
