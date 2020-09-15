using AssignmentManagement.Core.Domain;
using System.Collections.Generic;

namespace AssignmentManagement.Web.Api.Groups.GetGroups.Services
{
    public interface IGetGroupsService
    {
        Group GetGroupById(string groupId);
        IList<Group> ListGroupsByProfileId(string profileId);
    }
}
