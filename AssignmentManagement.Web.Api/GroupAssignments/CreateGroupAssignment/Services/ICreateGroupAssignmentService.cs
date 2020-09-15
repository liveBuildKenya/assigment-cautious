using AssignmentManagement.Core.Domain;
using AssignmentManagement.Web.Api.GroupAssignments.CreateGroupAssignment.Models;

namespace AssignmentManagement.Web.Api.GroupAssignments.CreateGroupAssignment.Services
{
    public interface ICreateGroupAssignmentService
    {
        GroupAssignment CreateGroupAssignment(CreateGroupAssignmentViewModel createGroupAssignmentViewModel);
    }
}
