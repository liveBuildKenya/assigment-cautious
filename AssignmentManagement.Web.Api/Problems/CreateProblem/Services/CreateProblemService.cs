using AssignmentManagement.Core.Domain;
using AssignmentManagement.Services.Problems;
using AssignmentManagement.Web.Api.Problems.CreateProblem.Models;
using System;

namespace AssignmentManagement.Web.Api.Problems.CreateProblem.Services
{
    public class CreateProblemService : ICreateProblemService
    {
        #region Fields

        private readonly IProblemService _problemService;

        #endregion

        #region Constructor

        public CreateProblemService(IProblemService problemService)
        {
            this._problemService = problemService;
        }

        #endregion

        #region Methods

        public CreateProblemResponseViewModel CreateProblem(CreateProblemViewModel createProblemViewModel)
        {
            var newProblem = new Problem
            {
                AuthorId = new Guid(createProblemViewModel.AuthorId),
                Title = createProblemViewModel.Title,
                Description = createProblemViewModel.Description,                                
            };

            foreach (var attachements in createProblemViewModel.Attachments)
            {
                newProblem.ProblemAttachments.Add(new ProblemAttachment
                {
                    FileId = attachements.FileId
                });
            }

            _problemService.InsertProblem(newProblem);

            return new CreateProblemResponseViewModel
            {
                CreatedProblem = (_problemService.GetProblemById(newProblem.Id))
            };
        }

        #endregion
    }
}
