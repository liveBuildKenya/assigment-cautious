using AssignmentManagement.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Seed.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AssignmentManagement.Services.Groups
{
    public class GroupService : IGroupService
    {
        #region Fields

        private IRepository<Group> _groupRepository;
        private IRepository<GroupProfile> _groupProfileRepository;

        #endregion

        #region Constructor

        public GroupService(IRepository<Group> groupRepository,
            IRepository<GroupProfile> groupProfileRepository)
        {
            this._groupRepository = groupRepository;
            this._groupProfileRepository = groupProfileRepository;
        }

        #endregion

        #region Methods

        public void InsertGroup(Group group)
        {
            if (group == null)
                throw new ArgumentNullException(nameof(Group));

            _groupRepository.Insert(group);
        }

        public void UpdateGroup(Group group)
        {
            if (group == null)
                throw new ArgumentNullException(nameof(Group));

            _groupRepository.Update(group);
        }

        public Group GetGroupById(Guid id)
        {
            return _groupRepository.Table
                .Include(group => group.GroupProfiles)
                .Where(group => group.Id == id)
                .FirstOrDefault();
        }

        public IList<Group> GetGroupsByProfileId(Guid profileId)
        {
            return _groupProfileRepository.Table
                .Include(groupProfile => groupProfile.Group).ThenInclude(group => group.GroupProfiles)
                .Where(groupProfile => groupProfile.ProfileId == profileId)
                .Select(groupProfile => groupProfile.Group)
                .ToList();
        }

        #endregion
    }
}
