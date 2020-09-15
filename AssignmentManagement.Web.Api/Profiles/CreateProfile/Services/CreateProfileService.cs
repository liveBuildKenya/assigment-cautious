using AssignmentManagement.Core.Domain;
using AssignmentManagement.Services.Profiles;
using AssignmentManagement.Web.Api.Profiles.CreateProfile.Models;

namespace AssignmentManagement.Web.Api.Profiles.CreateProfile.Services
{
    public class CreateProfileService : ICreateProfileService
    {
        #region Fields

        private readonly IProfileService _profileService;

        #endregion

        #region Constructor

        public CreateProfileService(IProfileService profileService)
        {
            this._profileService = profileService;
        }

        #endregion

        #region Methods

        public CreateProfileResponseViewModel CreateProfile(CreateProfileViewModel createProfileViewModel)
        {
            var newProfile = new Profile
            {
                IdentityId = createProfileViewModel.IdentityId,
                Name = createProfileViewModel.Name,
                SystemName = createProfileViewModel.SystemName
            };

            _profileService.InsertProfile(newProfile);



            return new CreateProfileResponseViewModel
            {
                Profile = (_profileService.GetProfileById(newProfile.Id))
            };
        }

        #endregion
    }
}
