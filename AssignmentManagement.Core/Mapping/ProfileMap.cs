using AssignmentManagement.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProfileManagement.Core.Mapping
{
    public class ProfileMap : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.ToTable(nameof(Profile));
            builder.HasKey(profile => profile.Id);
            builder.Property(profile => profile.Id).ValueGeneratedOnAdd();

            builder.Property(profile => profile.Name).IsRequired();
            builder.Property(profile => profile.SystemName).IsRequired();
            builder.Property(profile => profile.IdentityId).IsRequired();

            builder.HasMany(profile => profile.GroupProfiles)
                .WithOne(groupProfile => groupProfile.Profile)
                .HasForeignKey(groupProfile => groupProfile.ProfileId);
        }
    }
}
