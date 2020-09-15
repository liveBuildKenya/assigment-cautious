using AssignmentManagement.Core.Domain;
using AssignmentManagement.Services.GroupAssignments;
using AssignmentManagement.Web.Api.GroupAssignments.CreateGroupAssignment.Models;
using System;

namespace AssignmentManagement.Web.Api.GroupAssignments.CreateGroupAssignment.Services
{
    public class CreateGroupAssignmentService: ICreateGroupAssignmentService
    {
        #region Fields

        private readonly IGroupAssignmentService _groupAssignmentService;

        #endregion

        #region Constructor

        public CreateGroupAssignmentService(IGroupAssignmentService groupAssignmentService)
        {
            this._groupAssignmentService = groupAssignmentService;
        }

        #endregion

        #region Methods

        public GroupAssignment CreateGroupAssignment(CreateGroupAssignmentViewModel createGroupAssignmentViewModel)
        {
            var newGroupAssignment = new GroupAssignment
            {
                GroupId = new Guid(createGroupAssignmentViewModel.GroupId),
                ProblemId = new Guid(createGroupAssignmentViewModel.ProblemId),
                SubmissionDeadline = createGroupAssignmentViewModel.SubmissionDeadline
            };

            _groupAssignmentService.InsertGroupAssignment(newGroupAssignment);

            return _groupAssignmentService.GetGroupAssignmentByGroupIdAndProblemId(newGroupAssignment.GroupId, newGroupAssignment.ProblemId);
        }

        #endregion
    }
}
