using AssignmentManagement.Core.Domain;
using System.Collections.Generic;

namespace AssignmentManagement.Services.GroupAssignments
{
    public interface IGroupAssignmentService
    {
        void InsertGroupAssignment(GroupAssignment groupAssignment);
        GroupAssignment GetGroupAssignmentByGroupIdAndProblemId(string groupId, string problemId);
        IList<GroupAssignment> GetGroupAssignmentByGroupId(string groupId);
        IList<GroupAssignment> GetGroupAssignmentByProblemId(string problemId);
    }
}
