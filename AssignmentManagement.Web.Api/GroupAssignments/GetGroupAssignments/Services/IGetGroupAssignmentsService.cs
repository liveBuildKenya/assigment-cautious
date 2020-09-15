using AssignmentManagement.Core.Domain;
using System.Collections.Generic;

namespace AssignmentManagement.Web.Api.GroupAssignments.GetGroupAssignments.Services
{
    public interface IGetGroupAssignmentsService
    {
        IList<GroupAssignment> GetGroupAssignmentsByGroupId(string groupId);
        IList<GroupAssignment> GetGroupAssignmentsByProblemId(string problemId);
    }
}
