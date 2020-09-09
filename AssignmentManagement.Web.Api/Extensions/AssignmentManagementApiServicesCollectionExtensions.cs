using AssignmentManagement.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Seed.Infrastructure;
using AssignmentManagement.Services.Extensions;
using AssignmentManagement.Web.Api.CreateGroupAssignment.Services;
using AssignmentManagement.Web.Api.GetGroupAssignments.Services;

namespace AssignmentManagement.Web.Api.Extensions
{
    public static class AssignmentManagementApiServicesCollectionExtensions
    {
        public static void ConfigureAssignmentManagementApiServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<IDbContext, AssignmentDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("AssignmentManagementDbContext")));

            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

            services.ConfigureAssignmentManagementServiceServices();

            services.AddTransient<ICreateGroupAssignmentService, CreateGroupAssignmentService>();
            services.AddTransient<IGetGroupAssignmentsService, GetGroupAssignmentServices>();
        }
    }
}
