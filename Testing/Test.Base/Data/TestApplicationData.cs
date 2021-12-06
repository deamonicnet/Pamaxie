﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Pamaxie.Data;

namespace Test.Base
{
    /// <summary>
    /// Contains randomly generated <see cref="PamaxieApplication"/> Data
    /// </summary>
    public static class TestApplicationData
    {
        /// <summary>
        /// List of Test Applications
        /// </summary>
        public static readonly List<PamaxieApplication> ListOfApplications = new List<PamaxieApplication>
        {
            new PamaxieApplication
            {
                UniqueKey = "1064922",
                OwnerKey = "102617494281791801620",
                TTL = DateTime.Now,
                Credentials = new AppAuthCredentials
                {
                    AuthorizationToken = "Apple",
                    AuthorizationTokenCipher = "",
                    LastAuth = DateTime.Now
                },
                ApplicationName = "Sparkle",
                LastAuth = DateTime.Parse("15 05 2008", new CultureInfo("de-DE"))
            },
            new PamaxieApplication
            {
                UniqueKey = "1053324",
                OwnerKey = "102617494281791801620",
                TTL = DateTime.Now,
                Credentials = new AppAuthCredentials
                {
                    AuthorizationToken = "Pie",
                    AuthorizationTokenCipher = "",
                    LastAuth = DateTime.Now
                },
                ApplicationName = "Droop",
                LastAuth = DateTime.Parse("15 05 2008", new CultureInfo("de-DE"))
            },
            new PamaxieApplication
            {
                UniqueKey = "1051080",
                OwnerKey = "104669818103955818761",
                TTL = DateTime.Now,
                Credentials = new AppAuthCredentials
                {
                    AuthorizationToken = "Orange",
                    AuthorizationTokenCipher = "",
                    LastAuth = DateTime.Now
                },
                ApplicationName = "Cornwall",
                LastAuth = DateTime.Parse("15 05 2008", new CultureInfo("de-DE"))
            },
            new PamaxieApplication
            {
                UniqueKey = "1065779",
                OwnerKey = "104669818103955818761",
                TTL = DateTime.Now,
                Credentials = new AppAuthCredentials
                {
                    AuthorizationToken = "Pear",
                    AuthorizationTokenCipher = "",
                    LastAuth = DateTime.Now
                },
                ApplicationName = "Crystal",
                LastAuth = DateTime.Parse("15 05 2008", new CultureInfo("de-DE"))
            },
            new PamaxieApplication
            {
                UniqueKey = "1060105",
                OwnerKey = "104669818103955818761",
                TTL = DateTime.Now,
                Credentials = new AppAuthCredentials
                {
                    AuthorizationToken = "Cake",
                    AuthorizationTokenCipher = "",
                    LastAuth = DateTime.Now
                },
                ApplicationName = "Penny",
                LastAuth = DateTime.Parse("15 05 2008", new CultureInfo("de-DE"))
            }
        };
    }
}