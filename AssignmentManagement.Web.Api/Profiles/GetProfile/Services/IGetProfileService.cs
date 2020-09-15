using AssignmentManagement.Core.Domain;

namespace AssignmentManagement.Web.Api.Profiles.GetProfile.Services
{
    public interface IGetProfileService
    {
        Profile GetProfileById(string profileId);
        Profile GetProfileByIdentityId(string identityId);
    }
}
