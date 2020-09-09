using AssignmentManagement.Core.Domain;
using AssignmentManagement.Web.Api.CreateGroupAssignment.Models;

namespace AssignmentManagement.Web.Api.CreateGroupAssignment.Services
{
    public interface ICreateGroupAssignmentService
    {
        GroupAssignment CreateGroupAssignment(CreateGroupAssignmentViewModel createGroupAssignmentViewModel);
    }
}
