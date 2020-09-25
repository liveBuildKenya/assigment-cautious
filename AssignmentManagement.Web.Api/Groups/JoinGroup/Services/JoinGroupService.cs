using AssignmentManagement.Core.Domain;
using AssignmentManagement.Services.Groups;
using AssignmentManagement.Web.Api.Groups.JoinGroup.Models;

namespace AssignmentManagement.Web.Api.Groups.JoinGroup.Services
{
    public class JoinGroupService : IJoinGroupService
    {
        #region Fields

        private readonly IGroupService _groupService;

        #endregion

        #region Ctor

        public JoinGroupService(IGroupService groupService)
        {
            this._groupService = groupService;
        }

        #endregion

        #region Methods

        public Group JoinGroup(JoinGroupViewModel joinGroupViewModel)
        {
            var group = this._groupService.GetGroupById(joinGroupViewModel.groupId);

            group.GroupProfiles.Add(new GroupProfile { ProfileId = joinGroupViewModel.profileId });

            _groupService.UpdateGroup(group);

            return _groupService.GetGroupById(group.Id);

        }

        #endregion
    }
}
