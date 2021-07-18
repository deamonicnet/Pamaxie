﻿using Pamaxie.Data;
using Pamaxie.Database.Extensions.Sql.Data;
using Pamaxie.Database.Sql;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Pamaxie.Extensions.Sql
{
    public static class UserExtensions
    {
        /// <summary>
        /// Gets a user via their google User Id
        /// </summary>
        /// <param name="googleUserId">Id of the user to get the applications from</param>
        /// <returns></returns>
        public static User GetUser(string googleUserId)
        {
            using SqlDbContext dbContext = new();
            return dbContext.Users.FirstOrDefault(x => x.GoogleUserId == googleUserId);
        }
        
        /// <summary>
        /// Creates a new Application via the reached in variable
        /// </summary>
        /// <param name="userProfile"> The user to be created</param>
        /// <returns><see cref="bool"/> was success?</returns>
        public static bool CreateUser(IProfileData userProfile)
        {
            using SqlDbContext dbContext = new();
            try
            {
                User existingDbUser =
                    dbContext.Users.FirstOrDefault(x => x.GoogleUserId == userProfile.GoogleClaimUserId);
                if (existingDbUser != null)
                {
                    existingDbUser.DeletedAccount = false;
                    existingDbUser.Email = userProfile.EmailAddress;
                    existingDbUser.Username = userProfile.UserName;
                    dbContext.Update(existingDbUser);
                    dbContext.SaveChanges();
                    return true;
                }
                
                User user = new() { GoogleUserId = userProfile.GoogleClaimUserId, Email = userProfile.EmailAddress, Username = userProfile.UserName};
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception e) 
            {
                Console.WriteLine(e);
                return false;
            }
        }

        /// <summary>
        /// Deletes all data associated with a user profile from our database
        /// </summary>
        /// <param name="userProfile">User profile to delete</param>
        /// <returns><see cref="bool"/> was successful?</returns>
        public static bool DeleteUserData(this IProfileData userProfile)
        {
            using SqlDbContext dbContext = new();
            User user = dbContext.Users.FirstOrDefault(x => x.Id == userProfile.Id);
            if (user == null) return false;
            IEnumerable<Application> applications = ApplicationExtensions.GetApplications(userProfile.Id);
            foreach (Application application in applications)
            {
                application.DeleteApplication();

            }

            user.Email = string.Empty;
            user.Username = string.Empty;
            user.DeletedAccount = true;
            dbContext.Users.Update(user);
            dbContext.SaveChanges();
            return true;
        }
    }
}