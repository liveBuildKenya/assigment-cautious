using AssignmentManagement.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProblemManagement.Core.Mapping
{
    public class ProblemAttachmentMap : IEntityTypeConfiguration<ProblemAttachment>
    {
        public void Configure(EntityTypeBuilder<ProblemAttachment> builder)
        {
            builder.ToTable(nameof(ProblemAttachment));

            builder.HasKey(problemAttachement => problemAttachement.Id);

            builder.Property(problemAttachement => problemAttachement.Id)
                .ValueGeneratedOnAdd();

            builder.Property(problemAttachement => problemAttachement.FileId)
                .IsRequired();

            builder.Property(problemAttachement => problemAttachement.ProblemId)
                .IsRequired();

        }
    }
}
