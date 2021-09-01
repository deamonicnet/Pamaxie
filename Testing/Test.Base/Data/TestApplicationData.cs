﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Pamaxie.Data;

namespace Test.TestBase
{
    /// <summary>
    /// Contains randomly generated <see cref="IPamaxieApplication"/> Data
    /// </summary>
    public static class TestApplicationData
    {
        /// <summary>
        /// List of Test Applications
        /// </summary>
        public static readonly List<IPamaxieApplication> ListOfApplications = new()
        {
            new PamaxieApplication
            {
                Key = "64922",
                OwnerKey = "102617494281791801620",
                TTL = DateTime.Now,
                Credentials = new AppAuthCredentials
                {
                    AuthorizationToken = "Apple",
                    AuthorizationTokenCipher =
                        BCrypt.Net.BCrypt.HashPassword("Apple", BCryptExtension.CalculateSaltCost()),
                    LastAuth = DateTime.Now
                },
                ApplicationName = "Sparkle",
                LastAuth = DateTime.Parse("15 05 2008", new CultureInfo("de-DE")),
                RateLimited = false,
                Disabled = false,
                Deleted = false
            },
            new PamaxieApplication
            {
                Key = "53324",
                OwnerKey = "102617494281791801620",
                TTL = DateTime.Now,
                Credentials = new AppAuthCredentials
                {
                    AuthorizationToken = "Pie",
                    AuthorizationTokenCipher =
                        BCrypt.Net.BCrypt.HashPassword("Pie", BCryptExtension.CalculateSaltCost()),
                    LastAuth = DateTime.Now
                },
                ApplicationName = "Droop",
                LastAuth = DateTime.Parse("15 05 2008", new CultureInfo("de-DE")),
                RateLimited = false,
                Disabled = false,
                Deleted = false
            },
            new PamaxieApplication
            {
                Key = "51080",
                OwnerKey = "104669818103955818761",
                TTL = DateTime.Now,
                Credentials = new AppAuthCredentials
                {
                    AuthorizationToken = "Orange",
                    AuthorizationTokenCipher =
                        BCrypt.Net.BCrypt.HashPassword("Orange", BCryptExtension.CalculateSaltCost()),
                    LastAuth = DateTime.Now
                },
                ApplicationName = "Cornwall",
                LastAuth = DateTime.Parse("15 05 2008", new CultureInfo("de-DE")),
                RateLimited = false,
                Disabled = false,
                Deleted = false
            },
            new PamaxieApplication
            {
                Key = "65779",
                OwnerKey = "104669818103955818761",
                TTL = DateTime.Now,
                Credentials = new AppAuthCredentials
                {
                    AuthorizationToken = "Pear",
                    AuthorizationTokenCipher =
                        BCrypt.Net.BCrypt.HashPassword("Pear", BCryptExtension.CalculateSaltCost()),
                    LastAuth = DateTime.Now
                },
                ApplicationName = "Crystal",
                LastAuth = DateTime.Parse("15 05 2008", new CultureInfo("de-DE")),
                RateLimited = false,
                Disabled = false,
                Deleted = false
            },
            new PamaxieApplication
            {
                Key = "60105",
                OwnerKey = "104669818103955818761",
                TTL = DateTime.Now,
                Credentials = new AppAuthCredentials
                {
                    AuthorizationToken = "Cake",
                    AuthorizationTokenCipher =
                        BCrypt.Net.BCrypt.HashPassword("Cake", BCryptExtension.CalculateSaltCost()),
                    LastAuth = DateTime.Now
                },
                ApplicationName = "Penny",
                LastAuth = DateTime.Parse("15 05 2008", new CultureInfo("de-DE")),
                RateLimited = false,
                Disabled = false,
                Deleted = false
            }
        };
    }
}