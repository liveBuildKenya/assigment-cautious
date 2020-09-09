﻿using System;

namespace AssignmentManagement.Web.Api.CreateGroupAssignment.Models
{
    public class CreateGroupAssignmentViewModel
    {
        public string GroupId { get; set; }
        public string ProblemId { get; set; }
        public DateTime SubmissionDeadline { get; set; }
    }
}
