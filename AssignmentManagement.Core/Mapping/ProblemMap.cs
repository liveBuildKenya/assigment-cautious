using AssignmentManagement.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProblemManagement.Core.Mapping
{
    public class ProblemMap : IEntityTypeConfiguration<Problem>
    {
        public void Configure(EntityTypeBuilder<Problem> builder)
        {
            builder.ToTable(nameof(Problem));
            builder.HasKey(problem => problem.Id);
            builder.Property(problem => problem.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(problem => problem.Title).IsRequired();

            builder.HasOne(problem => problem.Author)
                    .WithMany(author => author.Problems)
                    .HasForeignKey(problem => problem.AuthorId);

            builder.HasMany(problem => problem.ProblemAttachments)
                .WithOne(problemAttachement => problemAttachement.Problem)
                .HasForeignKey(problemAttachement => problemAttachement.ProblemId);
        }
    }
}
