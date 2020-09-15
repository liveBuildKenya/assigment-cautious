using Seed;
using System;

namespace AssignmentManagement.Core.Domain
{
    /// <summary>
    /// Represents an attachment 
    /// </summary>
    public class ProblemAttachment : BaseEntity
    {
        /// <summary>
        /// Gets or sets the file identitfier
        /// </summary>
        public string FileId { get; set; }

        /// <summary>
        /// Gets or sets the problem identifier
        /// </summary>
        public Guid ProblemId { get; set; }

        /// <summary>
        /// Gets or sets the problem
        /// </summary>
        public Problem Problem { get; set; }
    }
}
