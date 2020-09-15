using Seed;
using System;

namespace AssignmentManagement.Core.Domain
{
    public class GroupAssignment: BaseEntity
    {
        public Group Group { get; set; }
        public Guid GroupId { get; set; }
        public Guid ProblemId { get; set; }
        public Problem Problem { get; set; }
        public DateTime SubmissionDeadline { get; set; }
    }
}
