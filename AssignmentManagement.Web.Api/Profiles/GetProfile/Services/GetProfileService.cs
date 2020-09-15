using AssignmentManagement.Core.Domain;
using AssignmentManagement.Services.Profiles;
using System;

namespace AssignmentManagement.Web.Api.Profiles.GetProfile.Services
{
    public class GetProfileService : IGetProfileService
    {
        #region Fields

        private readonly IProfileService _profileService;

        #endregion

        #region Ctor

        public GetProfileService(IProfileService profileService)
        {
            this._profileService = profileService;
        }

        #endregion

        #region Methods

        public Profile GetProfileById(string profileId)
        {
            return _profileService.GetProfileById(new Guid(profileId));
        }

        public Profile GetProfileByIdentityId(string identityId)
        {
            return _profileService.GetProfileByIdentityId(identityId);

        }

        #endregion
    }
}
