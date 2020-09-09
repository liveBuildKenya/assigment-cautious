using AssignmentManagement.Core.Domain;
using AssignmentManagement.Web.Api.CreateGroupAssignment.Models;
using AssignmentManagement.Web.Api.CreateGroupAssignment.Services;
using AssignmentManagement.Web.Api.GetGroupAssignments.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AssignmentManagement.Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AssignmentManagementController : ControllerBase
    {
        #region Fields

        private readonly ICreateGroupAssignmentService _createGroupAssignmentService;
        private readonly IGetGroupAssignmentsService _getGroupAssignmentService;

        #endregion

        #region Constructor

        public AssignmentManagementController(ICreateGroupAssignmentService createGroupAssignmentService,
            IGetGroupAssignmentsService getGroupAssignmentsService)
        {
            this._createGroupAssignmentService = createGroupAssignmentService;
            this._getGroupAssignmentService = getGroupAssignmentsService;
        }

        #endregion

        #region Methods

        [HttpPost]
        public GroupAssignment CreateGroupAssignment([FromBody] CreateGroupAssignmentViewModel createGroupAssignmentViewModel)
        {
            return _createGroupAssignmentService.CreateGroupAssignment(createGroupAssignmentViewModel);
        }

        [HttpGet("{groupId}")]
        public IList<GroupAssignment> GetAssignmentsByGroupId(string groupId)
        {
            return _getGroupAssignmentService.GetGroupAssignmentsByGroupId(groupId);
        }

        [HttpGet("{problemId}")]
        public IList<GroupAssignment> GetAssignmentsByProblemId(string problemId)
        {
            return _getGroupAssignmentService.GetGroupAssignmentsByProblemId(problemId);
        }

        #endregion
    }
}
