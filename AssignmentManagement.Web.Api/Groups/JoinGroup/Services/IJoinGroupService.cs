using AssignmentManagement.Core.Domain;
using AssignmentManagement.Web.Api.Groups.JoinGroup.Models;

namespace AssignmentManagement.Web.Api.Groups.JoinGroup.Services
{
    public interface IJoinGroupService
    {
        Group JoinGroup(JoinGroupViewModel joinGroupViewModel);
    }
}
