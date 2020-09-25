using System;
using System.Collections.Generic;

namespace AssignmentManagement.Web.Api.Problems.GetProblems.Models
{
    public class GetProblemsByIdsViewModel
    {
        public IList<Guid> problemIds { get; set; }
    }
}
