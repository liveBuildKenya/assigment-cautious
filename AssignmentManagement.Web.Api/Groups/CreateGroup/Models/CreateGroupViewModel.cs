using System.Collections.Generic;

namespace AssignmentManagement.Web.Api.Groups.CreateGroup.Models
{
    public class CreateGroupViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<GroupProfileViewModel> GroupProfiles { get; set; }
    }
}
