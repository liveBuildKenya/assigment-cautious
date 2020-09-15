using AssignmentManagement.Core.Domain;
using Seed.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AssignmentManagement.Services.GroupAssignments
{
    public class GroupAssignmentService : IGroupAssignmentService
    {
        #region Fields

        private readonly IRepository<GroupAssignment> _groupAssignmentRepository;

        #endregion

        #region Constructor

        public GroupAssignmentService(IRepository<GroupAssignment> groupAssignmentService)
        {
            this._groupAssignmentRepository = groupAssignmentService;
        }

        #endregion

        #region Methods

        public void InsertGroupAssignment(GroupAssignment groupAssignment)
        {
            if (groupAssignment == null)
                throw new ArgumentNullException(nameof(GroupAssignment));

            _groupAssignmentRepository.Insert(groupAssignment);
        }

        public GroupAssignment GetGroupAssignmentByGroupIdAndProblemId(Guid groupId, Guid problemId)
        {
            return _groupAssignmentRepository.Table
                .Where(groupAssignment => groupAssignment.GroupId == groupId && groupAssignment.ProblemId == problemId)
                .FirstOrDefault();
        }

        public IList<GroupAssignment> GetGroupAssignmentByGroupId(Guid groupId)
        {
            return _groupAssignmentRepository.Table
                .Where(groupAssignment => groupAssignment.GroupId == groupId)
                .ToList();
        }

        public IList<GroupAssignment> GetGroupAssignmentByProblemId(Guid problemId)
        {
            return _groupAssignmentRepository.Table
                .Where(groupAssignment => groupAssignment.ProblemId == problemId)
                .ToList();
        }

        #endregion
    }
}
