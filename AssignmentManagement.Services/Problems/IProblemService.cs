using AssignmentManagement.Core.Domain;
using System;
using System.Collections.Generic;

namespace AssignmentManagement.Services.Problems
{
    public interface IProblemService
    {
        /// <summary>
        /// Inserts a problem
        /// </summary>
        /// <param name="problem">Problem</param>
        void InsertProblem(Problem problem);

        /// <summary>
        /// Updates a problem
        /// </summary>
        /// <param name="problem">Problem</param>
        void UpdateProblem(Problem problem);

        /// <summary>
        /// Deletes a problem
        /// </summary>
        /// <param name="problem">Problem</param>
        void DeleteProblem(Problem problem);
        IList<Problem> GetProblemsByAuthorId(string authorId);

        /// <summary>
        /// Gets a problem by identifier
        /// </summary>
        /// <param name="problemId"></param>
        /// <returns>Problem</returns>
        Problem GetProblemById(Guid problemId);
        IList<Problem> GetProblemsByIds(IList<Guid> problemIds);
    }
}
