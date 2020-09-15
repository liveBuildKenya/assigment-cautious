using AssignmentManagement.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroupManagement.Core.Mapping
{
    public class GroupProfileMap : IEntityTypeConfiguration<GroupProfile>
    {
        public void Configure(EntityTypeBuilder<GroupProfile> builder)
        {
            builder.ToTable(nameof(GroupProfile));

            builder.Ignore(groupProfile => groupProfile.Id);

            builder.HasKey(groupProfile => new { groupProfile.GroupId, groupProfile.ProfileId });
        }
    }
}
