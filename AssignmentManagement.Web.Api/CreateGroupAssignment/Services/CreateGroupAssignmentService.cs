using AssignmentManagement.Core.Domain;
using AssignmentManagement.Services.GroupAssignments;
using AssignmentManagement.Web.Api.CreateGroupAssignment.Models;

namespace AssignmentManagement.Web.Api.CreateGroupAssignment.Services
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
                GroupId = createGroupAssignmentViewModel.GroupId,
                ProblemId = createGroupAssignmentViewModel.ProblemId,
                SubmissionDeadline = createGroupAssignmentViewModel.SubmissionDeadline
            };

            _groupAssignmentService.InsertGroupAssignment(newGroupAssignment);

            return _groupAssignmentService.GetGroupAssignmentByGroupIdAndProblemId(newGroupAssignment.GroupId, newGroupAssignment.ProblemId);
        }

        #endregion
    }
}
