using Microsoft.Extensions.DependencyInjection;
using Training.B.Services.Contracts;

namespace Training.B.Services
{
    public static class ServicesFrameworkServiceExtension
    {
        public static void AddTrainingBServices(this IServiceCollection services)
        {
            services.AddTransient<IContentService, ContentService>();
        }
    }
}