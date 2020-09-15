using AssignmentManagement.Web.Api.Problems.CreateProblem.Models;

namespace AssignmentManagement.Web.Api.Problems.CreateProblem.Services
{
    public interface ICreateProblemService
    {
        CreateProblemResponseViewModel CreateProblem(CreateProblemViewModel createProblemViewModel);
    }
}
