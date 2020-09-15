using AssignmentManagement.Core.Domain;
using System;
using System.Collections.Generic;

namespace AssignmentManagement.Services.Groups
{
    public interface IGroupService
    {
        /// <summary>
        /// Inserts a group
        /// </summary>
        /// <param name="group">Group</param>
        void InsertGroup(Group group);

        /// <summary>
        /// Gets a group by id
        /// </summary>
        /// <param name="id">Group Id</param>
        /// <returns>Group</returns>
        Group GetGroupById(Guid id);

        /// <summary>
        /// Gets a list of group by profile identifier
        /// </summary>
        /// <param name="profileId">Profile identifier</param>
        /// <returns>Groups</returns>
        IList<Group> GetGroupsByProfileId(Guid profileId);
    }
}
