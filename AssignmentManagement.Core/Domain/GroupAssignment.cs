using Seed;
using System;

namespace AssignmentManagement.Core.Domain
{
    public class GroupAssignment: BaseEntity
    {
        public string GroupId { get; set; }
        public string ProblemId { get; set; }
        public DateTime SubmissionDeadline { get; set; }
    }
}
