﻿using AssignmentManagement.Core.Domain;
using AssignmentManagement.Web.Api.GroupAssignments.CreateGroupAssignment.Models;
using AssignmentManagement.Web.Api.GroupAssignments.CreateGroupAssignment.Services;
using AssignmentManagement.Web.Api.GroupAssignments.GetGroupAssignments.Services;
using AssignmentManagement.Web.Api.Groups.CreateGroup.Models;
using AssignmentManagement.Web.Api.Groups.CreateGroup.Services;
using AssignmentManagement.Web.Api.Groups.GetGroups.Services;
using AssignmentManagement.Web.Api.Problems.CreateProblem.Models;
using AssignmentManagement.Web.Api.Problems.CreateProblem.Services;
using AssignmentManagement.Web.Api.Problems.GetProblems.Services;
using AssignmentManagement.Web.Api.Profiles.CreateProfile.Models;
using AssignmentManagement.Web.Api.Profiles.CreateProfile.Services;
using AssignmentManagement.Web.Api.Profiles.GetProfile.Services;
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
        private readonly ICreateGroupService _createGroupService;
        private readonly IGetGroupsService _getGroupsService;
        private readonly ICreateProblemService _createProblemService;
        private readonly IGetProblemsService _getProblemsService;
        private readonly ICreateProfileService _createProfileService;
        private readonly IGetProfileService _getProfileService;

        #endregion

        #region Constructor

        public AssignmentManagementController(ICreateGroupAssignmentService createGroupAssignmentService,
            IGetGroupAssignmentsService getGroupAssignmentsService,
            ICreateGroupService createGroupService,
            IGetGroupsService getGroupsService,
            ICreateProblemService createProblemsService,
            IGetProblemsService getProblemsService,
            ICreateProfileService createProfileService,
            IGetProfileService getProfileService)
        {
            this._createGroupAssignmentService = createGroupAssignmentService;
            this._getGroupAssignmentService = getGroupAssignmentsService;
            this._createGroupService = createGroupService;
            this._getGroupsService = getGroupsService;
            this._createProblemService = createProblemsService;
            this._getProblemsService = getProblemsService;
            this._createProfileService = createProfileService;
            this._getProfileService = getProfileService;
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

        [HttpPost]
        public CreateProfileResponseViewModel CreateProfile(CreateProfileViewModel createProfileViewModel)
        {
            return _createProfileService.CreateProfile(createProfileViewModel);
        }

        [HttpGet("{profileId}")]
        public Profile GetProfileById(string profileId)
        {
            return _getProfileService.GetProfileById(profileId);
        }

        [HttpGet("{identityId}")]
        public Profile GetProfileByIdentityId(string identityId)
        {
            return _getProfileService.GetProfileByIdentityId(identityId);
        }

        [HttpPost]
        public CreateProblemResponseViewModel CreateProblem([FromBody] CreateProblemViewModel createProblemViewModel)
        {
            return _createProblemService.CreateProblem(createProblemViewModel);
        }

        [HttpGet("{authorId}")]
        public IList<Problem> GetProblemsByAuthorId(string authorId)
        {
            return _getProblemsService.GetProblemsByAuthorId(authorId);
        }

        [HttpGet("{problemId}")]
        public Problem GetProblemById(string problemId)
        {
            return _getProblemsService.GetProblemById(problemId);
        }

        [HttpPost]
        public CreateGroupResponseViewModel CreateGroup([FromBody] CreateGroupViewModel createGroupViewModel)
        {
            return _createGroupService.CreateGroup(createGroupViewModel);
        }

        [HttpGet("{profileId}")]
        public IList<Group> ListGroups(string profileId)
        {
            return _getGroupsService.ListGroupsByProfileId(profileId);
        }

        [HttpGet("{groupId}")]
        public Group GetGroup(string groupId)
        {
            return _getGroupsService.GetGroupById(groupId);
        }

        #endregion
    }
}
