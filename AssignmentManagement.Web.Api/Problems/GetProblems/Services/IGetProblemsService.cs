using AssignmentManagement.Core.Domain;
using AssignmentManagement.Web.Api.Problems.GetProblems.Models;
using System.Collections.Generic;

namespace AssignmentManagement.Web.Api.Problems.GetProblems.Services
{
    public interface IGetProblemsService
    {
        Problem GetProblemById(string problemId);
        IList<Problem> GetProblemsByAuthorId(string authorId);
        IList<Problem> GetProblemsByIds(GetProblemsByIdsViewModel getProblemByIdsViewModel);
    }
}
