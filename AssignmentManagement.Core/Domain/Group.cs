using Seed;
using System.Collections.Generic;

namespace AssignmentManagement.Core.Domain
{
    public class Group : BaseEntity
    {
        private ICollection<GroupProfile> _groupProfiles;

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the group profiles
        /// </summary>
        public virtual ICollection<GroupProfile> GroupProfiles
        {
            get => _groupProfiles ?? (_groupProfiles = new List<GroupProfile>());
            protected set => _groupProfiles = value;
        }
    }
}
