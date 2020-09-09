using AssignmentManagement.Services.GroupAssignments;
using Microsoft.Extensions.DependencyInjection;

namespace AssignmentManagement.Services.Extensions
{
    public static class AssignmentManagementServiceServicesCollectionExtension
    {
        public static void ConfigureAssignmentManagementServiceServices(this IServiceCollection services)
        {
            services.AddTransient<IGroupAssignmentService, GroupAssignmentService>();
        }
    }
}
