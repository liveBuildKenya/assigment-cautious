using AssignmentManagement.Web.Api.Profiles.CreateProfile.Models;

namespace AssignmentManagement.Web.Api.Profiles.CreateProfile.Services
{
    public interface ICreateProfileService
    {
        CreateProfileResponseViewModel CreateProfile(CreateProfileViewModel createProfile);
    }
}
