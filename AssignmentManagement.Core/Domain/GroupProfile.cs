using Seed;
using System;

namespace AssignmentManagement.Core.Domain
{
    public class GroupProfile : BaseEntity
    {
        /// <summary>
        /// Gets or sets the group identifier
        /// </summary>
        public Guid GroupId { get; set; }

        /// <summary>
        /// Gets or sets the group
        /// </summary>
        public Group Group { get; set; }

        /// <summary>
        /// Gets or sets the profile identifier
        /// </summary>
        public Guid ProfileId { get; set; }

        /// <summary>
        /// Gets or sets the profile
        /// </summary>
        public Profile Profile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the profile is an admin
        /// </summary>
        public bool IsAdmin { get; set; }
    }
}
