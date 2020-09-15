using AssignmentManagement.Core.Domain;
using System.Collections.Generic;

namespace AssignmentManagement.Web.Api.Problems.GetProblems.Services
{
    public interface IGetProblemsService
    {
        Problem GetProblemById(string problemId);
        IList<Problem> GetProblemsByAuthorId(string authorId);
    }
}
