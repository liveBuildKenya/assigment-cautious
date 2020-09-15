using AssignmentManagement.Web.Api.Groups.CreateGroup.Models;

namespace AssignmentManagement.Web.Api.Groups.CreateGroup.Services
{
    public interface ICreateGroupService
    {
        CreateGroupResponseViewModel CreateGroup(CreateGroupViewModel createGroupViewModel);
    }
}
