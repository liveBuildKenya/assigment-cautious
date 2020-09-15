using AssignmentManagement.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroupManagement.Core.Mapping
{
    public class GroupMap : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.ToTable(nameof(Group));
            builder.HasKey(group => group.Id);

            builder.Property(group => group.Id).ValueGeneratedOnAdd();

            builder.HasMany(group => group.GroupProfiles)
                .WithOne(groupProfile => groupProfile.Group)
                .HasForeignKey(groupProfile => groupProfile.GroupId);
        }
    }
}
