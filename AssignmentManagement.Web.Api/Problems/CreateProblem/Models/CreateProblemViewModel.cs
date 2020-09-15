using System.Collections.Generic;

namespace AssignmentManagement.Web.Api.Problems.CreateProblem.Models
{
    public class CreateProblemViewModel
    {
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
        public string AuthorId { get; set; }

        /// <summary>
        /// Gets or sets the Attachements
        /// </summary>
        public IList<AttachmentViewModel> Attachments { get; set; }
    }
}
