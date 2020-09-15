using AssignmentManagement.Core.Domain;
using AssignmentManagement.Services.Groups;
using AssignmentManagement.Web.Api.Groups.CreateGroup.Models;
using System;

namespace AssignmentManagement.Web.Api.Groups.CreateGroup.Services
{
    public class CreateGroupService : ICreateGroupService
    {
        #region Fields

        private readonly IGroupService _groupService;

        #endregion

        #region Constructor

        public CreateGroupService(IGroupService groupService)
        {
            this._groupService = groupService;
        }
        #endregion

        #region Methods

        public CreateGroupResponseViewModel CreateGroup(CreateGroupViewModel createGroupViewModel)
        {
            var newGroup = new Group
            {
                Name = createGroupViewModel.Name,
                Description = createGroupViewModel.Description
            };

            if (createGroupViewModel.GroupProfiles != null)
            {
                foreach (var profile in createGroupViewModel.GroupProfiles)
                {
                    newGroup.GroupProfiles.Add(new GroupProfile
                    {
                        IsAdmin = profile.IsAdmin,
                        ProfileId = new Guid(profile.ProfileId)
                    });
                }
            }

            _groupService.InsertGroup(newGroup);

            return new CreateGroupResponseViewModel
            {
                CreatedGroup = _groupService.GetGroupById(newGroup.Id)
            };
        }

        #endregion
    }
}
