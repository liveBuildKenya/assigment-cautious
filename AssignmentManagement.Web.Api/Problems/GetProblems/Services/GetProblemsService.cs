using AssignmentManagement.Core.Domain;
using AssignmentManagement.Services.Problems;
using System;
using System.Collections.Generic;

namespace AssignmentManagement.Web.Api.Problems.GetProblems.Services
{
    public class GetProblemsService : IGetProblemsService
    {
        #region Fields

        private readonly IProblemService _problemService;

        #endregion

        #region Ctor

        public GetProblemsService(IProblemService problemService)
        {
            this._problemService = problemService;
        }

        #endregion

        #region Methods

        public IList<Problem> GetProblemsByAuthorId(string authorId)
        {
            return _problemService.GetProblemsByAuthorId(authorId);
        }

        public Problem GetProblemById(string problemId)
        {
            return _problemService.GetProblemById(new Guid(problemId));
        }

        #endregion
    }
}
