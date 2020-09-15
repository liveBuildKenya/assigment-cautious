using AssignmentManagement.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Seed.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AssignmentManagement.Services.Profiles
{
    public class ProfileService : IProfileService
    {
        #region Fields

        private readonly IRepository<Profile> _profileRepository;

        #endregion

        #region Constructor

        public ProfileService(IRepository<Profile> profileRepository)
        {
            this._profileRepository = profileRepository;
        }

        #endregion

        #region Methods

        public void DeleteProfile(Profile profile)
        {
            if (profile == null)
                throw new ArgumentNullException(nameof(profile));

            _profileRepository.Delete(profile);
        }

        public Profile GetProfileById(Guid profileId)
        {
            return _profileRepository.GetById(profileId);
        }

        public IList<Profile> GetProfilesByIdentityId(string identityId)
        {
            if (string.IsNullOrWhiteSpace(identityId))
                return null;

            var query = from profile in _profileRepository.Table
                        orderby profile.Id
                        where profile.IdentityId == identityId
                        select profile;
            return query.ToList();
        }

        public Profile GetProfileByIdentityId(string identityId)
        {
            if (string.IsNullOrWhiteSpace(identityId))
                return null;

            return _profileRepository.Table
                .Include(profile => profile.GroupProfiles)
                .ThenInclude(groupProfile => groupProfile.Group)
                .Include(profile => profile.Problems)
                .ThenInclude(problem => problem.ProblemAttachments)
                .Where(profile => profile.IdentityId == identityId)
                .FirstOrDefault();
        }

        public void InsertProfile(Profile profile)
        {
            if (profile == null)
                throw new ArgumentNullException(nameof(profile));

            _profileRepository.Insert(profile);
        }

        public void UpdateProfile(Profile profile)
        {
            if (profile == null)
                throw new ArgumentNullException(nameof(profile));

            _profileRepository.Update(profile);
        }

        #endregion
    }
}
