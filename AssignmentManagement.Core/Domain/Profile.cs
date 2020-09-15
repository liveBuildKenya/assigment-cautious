using Seed;
using System.Collections;
using System.Collections.Generic;

namespace AssignmentManagement.Core.Domain
{
    public class Profile : BaseEntity
    {
        private ICollection<Problem> _problems;
        private ICollection<GroupProfile> _groupProfiles;

        public string Name { get; set; }
        public string SystemName { get; set; }
        public string IdentityId { get; set; }
        public virtual ICollection<Problem> Problems
        {
            get => _problems ?? (_problems = new List<Problem>());
            protected set => _problems = value;
        }

        public virtual ICollection<GroupProfile> GroupProfiles
        {
            get => _groupProfiles ?? (_groupProfiles = new List<GroupProfile>());
            protected set => _groupProfiles = value;
        }
    }
}
