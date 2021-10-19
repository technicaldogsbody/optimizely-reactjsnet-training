using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Training.B.Requests
{
    public static class RequestFrameworkServiceExtension
    {
        public static void AddTrainingBRequests(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetAssembly(typeof(RequestFrameworkServiceExtension)));
        }
    }
}