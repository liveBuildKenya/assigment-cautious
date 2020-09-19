using AssignmentManagement.Services.Groups;
using AssignmentManagement.Services.Problems;
using AssignmentManagement.Services.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace AssignmentManagement.Services.Extensions
{
    public static class AssignmentManagementServiceServicesCollectionExtension
    {
        public static void ConfigureAssignmentManagementServiceServices(this IServiceCollection services)
        {
            services.AddTransient<IGroupService, GroupService>();
            services.AddTransient<IProblemService, ProblemService>();
            services.AddTransient<IProfileService, ProfileService>();
        }
    }
}
