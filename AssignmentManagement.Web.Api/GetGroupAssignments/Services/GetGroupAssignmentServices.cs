using AssignmentManagement.Core.Domain;
using AssignmentManagement.Services.GroupAssignments;
using System.Collections.Generic;

namespace AssignmentManagement.Web.Api.GetGroupAssignments.Services
{
    public class GetGroupAssignmentServices : IGetGroupAssignmentsService
    {
        #region Fields

        private readonly IGroupAssignmentService _groupAssignmentService;

        #endregion

        #region Constructor

        public GetGroupAssignmentServices(IGroupAssignmentService groupAsssignmentService)
        {
            this._groupAssignmentService = groupAsssignmentService;
        }

        #endregion

        #region Methods

        public IList<GroupAssignment> GetGroupAssignmentsByGroupId(string groupId)
        {
            return _groupAssignmentService.GetGroupAssignmentByGroupId(groupId);
        }

        public IList<GroupAssignment> GetGroupAssignmentsByProblemId(string problemId)
        {
            return _groupAssignmentService.GetGroupAssignmentByProblemId(problemId);
        }

        #endregion
    }
}
