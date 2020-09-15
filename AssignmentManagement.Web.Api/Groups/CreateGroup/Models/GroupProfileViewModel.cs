namespace AssignmentManagement.Web.Api.Groups.CreateGroup.Models
{
    public class GroupProfileViewModel
    {
        /// <summary>
        /// Gets or sets the profile identifier
        /// </summary>
        public string ProfileId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is an admin
        /// </summary>
        public bool IsAdmin { get; set; }
    }
}
