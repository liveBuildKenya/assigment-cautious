using AssignmentManagement.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Seed.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AssignmentManagement.Services.Problems
{
    public class ProblemService : IProblemService
    {
        #region Fields

        private IRepository<Problem> _problemRepository;

        #endregion

        #region Ctor

        public ProblemService(IRepository<Problem> problemRepository)
        {
            this._problemRepository = problemRepository;
        }

        #endregion

        #region Methods

        public void DeleteProblem(Problem problem)
        {
            if (problem == null)
                throw new ArgumentNullException(nameof(problem));

            _problemRepository.Delete(problem);
        }

        public IList<Problem> GetProblemsByAuthorId(string authorId)
        {
            return _problemRepository.Table
                .Include(problem => problem.ProblemAttachments)
                .Where(problem => problem.AuthorId == new Guid(authorId))
                .ToList();
        }

        public Problem GetProblemById(Guid problemId)
        {
            if (problemId == null)
                throw new ArgumentNullException(nameof(problemId));

            return _problemRepository.Table
                .Include(problem => problem.ProblemAttachments)
                .Where(problem => problem.Id == problemId)
                .FirstOrDefault();
        }

        public void InsertProblem(Problem problem)
        {
            if (problem == null)
                throw new ArgumentNullException(nameof(problem));

            _problemRepository.Insert(problem);
        }

        public void UpdateProblem(Problem problem)
        {
            if (problem == null)
                throw new ArgumentNullException(nameof(problem));

            _problemRepository.Update(problem);
        }

        #endregion
    }
}
