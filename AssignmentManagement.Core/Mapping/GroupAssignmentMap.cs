using AssignmentManagement.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssignmentManagement.Core.Mapping
{
    public class GroupAssignmentMap : IEntityTypeConfiguration<GroupAssignment>
    {
        public void Configure(EntityTypeBuilder<GroupAssignment> builder)
        {
            builder.ToTable(nameof(GroupAssignment));
            builder.Ignore(groupAssignment => groupAssignment.Id);
            builder.HasKey(groupAssignment => new { groupAssignment.ProblemId, groupAssignment.GroupId });

            builder.Property(groupAssignment => groupAssignment.SubmissionDeadline).IsRequired();
        }
    }
}
