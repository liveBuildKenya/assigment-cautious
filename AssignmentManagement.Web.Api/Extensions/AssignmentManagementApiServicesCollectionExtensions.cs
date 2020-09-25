using AssignmentManagement.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Seed.Infrastructure;
using AssignmentManagement.Services.Extensions;
using AssignmentManagement.Web.Api.Groups.CreateGroup.Services;
using AssignmentManagement.Web.Api.Groups.GetGroups.Services;
using AssignmentManagement.Web.Api.Problems.CreateProblem.Services;
using AssignmentManagement.Web.Api.Problems.GetProblems.Services;
using AssignmentManagement.Web.Api.Profiles.CreateProfile.Services;
using AssignmentManagement.Web.Api.Profiles.GetProfile.Services;
using AssignmentManagement.Web.Api.Groups.JoinGroup.Services;

namespace AssignmentManagement.Web.Api.Extensions
{
    public static class AssignmentManagementApiServicesCollectionExtensions
    {
        public static void ConfigureAssignmentManagementApiServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<IDbContext, AssignmentDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("AssignmentManagementDbContext")));

            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

            services.ConfigureAssignmentManagementServiceServices();

            services.AddTransient<ICreateGroupService, CreateGroupService>();
            services.AddTransient<IGetGroupsService, GetGroupsService>();
            services.AddTransient<IJoinGroupService, JoinGroupService>();
            services.AddTransient<ICreateProblemService, CreateProblemService>();
            services.AddTransient<IGetProblemsService, GetProblemsService>();
            services.AddTransient<ICreateProfileService, CreateProfileService>();
            services.AddTransient<IGetProfileService, GetProfileService>();
        }
    }
}
