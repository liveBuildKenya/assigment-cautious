using AssignmentManagement.Core.Domain;
using System;
using System.Collections;
using System.Collections.Generic;

namespace AssignmentManagement.Services.Profiles
{
    public interface IProfileService
    {
        /// <summary>
        /// Inserts a profile
        /// </summary>
        /// <param name="profile">Profile</param>
        void InsertProfile(Profile profile);

        /// <summary>
        /// Updates a profile
        /// </summary>
        /// <param name="profile">Profile</param>
        void UpdateProfile(Profile profile);

        /// <summary>
        /// Deletes a profile
        /// </summary>
        /// <param name="profile">Profile</param>
        void DeleteProfile(Profile profile);

        /// <summary>
        /// Gets a profile by identifier
        /// </summary>
        /// <param name="profileId">Profile identifier</param>
        /// <returns></returns>
        Profile GetProfileById(Guid profileId);

        /// <summary>
        /// Gets profile by identity identifier
        /// </summary>
        /// <param name="identityId">Identity Identifier</param>
        /// <returns></returns>
        IList<Profile> GetProfilesByIdentityId(string identityId);

        /// <summary>
        /// Gets profile by identity identifier
        /// </summary>
        /// <param name="identityId">Identity Identifier</param>
        /// <returns></returns>
        Profile GetProfileByIdentityId(string identityId);
    }
}
