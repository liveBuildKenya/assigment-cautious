using AssignmentManagement.Core.Domain;
using AssignmentManagement.Services.Groups;
using System;
using System.Collections.Generic;

namespace AssignmentManagement.Web.Api.Groups.GetGroups.Services
{
    public class GetGroupsService : IGetGroupsService
    {
        #region Fields

        private readonly IGroupService _groupService;

        #endregion

        #region Ctor

        public GetGroupsService(IGroupService groupService)
        {
            this._groupService = groupService;
        }

        #endregion

        #region Methods

        public Group GetGroupById(string groupId)
        {
            return _groupService.GetGroupById(new Guid(groupId));
        }

        public IList<Group> ListGroupsByProfileId(string profileId)
        {
            return _groupService.GetGroupsByProfileId(new Guid(profileId));
        }

        #endregion
    }
}
