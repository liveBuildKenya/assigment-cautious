using AssignmentManagement.Core.Domain;
using System;
using System.Collections.Generic;

namespace AssignmentManagement.Services.GroupAssignments
{
    public interface IGroupAssignmentService
    {
        void InsertGroupAssignment(GroupAssignment groupAssignment);
        GroupAssignment GetGroupAssignmentByGroupIdAndProblemId(Guid groupId, Guid problemId);
        IList<GroupAssignment> GetGroupAssignmentByGroupId(Guid groupId);
        IList<GroupAssignment> GetGroupAssignmentByProblemId(Guid problemId);
    }
}
