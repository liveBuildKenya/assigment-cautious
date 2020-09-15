using Seed;
using System;
using System.Collections.Generic;

namespace AssignmentManagement.Core.Domain
{
    /// <summary>
    /// Represents a problem assignment
    /// </summary>
    public class Problem : BaseEntity
    {
        private ICollection<ProblemAttachment> _problemAttachments;

        /// <summary>
        /// Gets or sets the title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }


        /// <summary>
        /// Gets or sets the author identifier
        /// </summary>
        public Guid AuthorId { get; set; }

        public Profile Author { get; set; }

        /// <summary>
        /// Gets or sets the problem attachements
        /// </summary>
        public virtual ICollection<ProblemAttachment> ProblemAttachments
        {
            get => _problemAttachments ?? (_problemAttachments = new List<ProblemAttachment>());
            protected set => _problemAttachments = value;
        }
    }
}
