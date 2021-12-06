﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Pamaxie.Data;

namespace Test.Base
{
    /// <summary>
    /// Contains randomly generated <see cref="PamaxieUser"/> Data
    /// </summary>
    public static class TestUserData
    {
        /// <summary>
        /// List of Test Users
        /// </summary>
        public static readonly List<PamaxieUser> ListOfUsers = new List<PamaxieUser>
        {
            new PamaxieUser
            {
                UniqueKey = "108533958726952849891",
                UserName = "Xystosie",
                FirstName = "Santina",
                LastName = "Xystos",
                EmailAddress = "Saxy@fakemail.com",
                EmailVerified = false,
                ProfilePictureAddress =
                    "https://lh3.googleusercontent.com/-KHm9C7OfwHE/YRygoiMAYaI/AAAAAAAAAIU/EtHpaiw9rqQiXwbtloPiN-hhxuRRJmJFwCMICGAYYCw/s96-c",
                ApplicationKeys = new List<string>().AsEnumerable()
            },
            new PamaxieUser
            {
                UniqueKey = "102617494281791801620",
                UserName = "Indrakitten",
                FirstName = "Indra",
                LastName = "Aronne",
                EmailAddress = "Inar@fakemail.com",
                EmailVerified = true,
                ProfilePictureAddress =
                    "https://lh3.googleusercontent.com/-gN0jNA4zEEc/YRyhZ7pvf4I/AAAAAAAAAKo/a0Zi5AZgM4Umg4hWhtGB0bMz8RAt8bKHgCMICGAYYCw/s96-c",
                ApplicationKeys = new[] { "1064922", "1053324" }
            },
            new PamaxieUser
            {
                UniqueKey = "103932469084294046511",
                UserName = "Maxster",
                FirstName = "Oshrat",
                LastName = "Max",
                EmailAddress = "Osma@fakemail.com",
                EmailVerified = false,
                ProfilePictureAddress =
                    "https://lh3.googleusercontent.com/-ZoqFDMxHwW8/YRyhOXy4usI/AAAAAAAAAKI/aYF2Yf-OkgA1A5Q4h2H5Kl1uyEpH3FwsgCMICGAYYCw/s96-c",
                ApplicationKeys = new List<string>().AsEnumerable()
            },
            new PamaxieUser
            {
                UniqueKey = "104669818103955818761",
                UserName = "Paulo",
                FirstName = "Paulus",
                LastName = "Ferdinand",
                EmailAddress = "Pafe@fakemail.com",
                EmailVerified = true,
                ProfilePictureAddress =
                    "https://lh3.googleusercontent.com/-sWl6t08Q35E/YRyhBB8AlkI/AAAAAAAAAJQ/BO8AYPZlG90gQEND_C_W63fGEnRBvLnhQCMICGAYYCw/s96-c",
                ApplicationKeys = new[] { "1051080", "1065779", "1060105" }
            },
            new PamaxieUser
            {
                UniqueKey = "101321258707856828644",
                UserName = "Mana",
                FirstName = "Manuela",
                LastName = "Jéssica",
                EmailAddress = "Maje@fakemail.com",
                EmailVerified = false,
                ProfilePictureAddress =
                    "https://lh3.googleusercontent.com/-njVNd76BfGQ/YRyhHMcQWRI/AAAAAAAAAJw/dLEOLMKV7Tk8-NrNNRyh5r-lAGd1DPmqwCMICGAYYCw/s96-c",
                ApplicationKeys = new List<string>().AsEnumerable()
            }
        };

        static TestUserData()
        {
            //Check if configuration file exists before adding personal testing data
            if (File.Exists("appsettings.test.json"))
            {
                IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.test.json").Build();

                if (configuration.GetChildren().Any(_ => _.Key == "UserData"))
                {
                    IConfigurationSection configurationSection = configuration.GetSection("UserData");

                    //Check if a email is given
                    string email = configurationSection.GetValue<string>("EmailAddress");

                    if (!string.IsNullOrEmpty(email))
                    {
                        //Add the user to the list of users
                        PamaxieUser pamaxieUser = new PamaxieUser
                        {
                            UniqueKey = "101963629560135630792",
                            UserName = "PersonalUser",
                            FirstName = "Lucy",
                            LastName = "Pamaxie",
                            EmailAddress = email,
                            EmailVerified = false,
                            ProfilePictureAddress =
                                "https://lh3.googleusercontent.com/-K6jEW8D8F4E/YRy0Zw8i-OI/AAAAAAAAAMQ/pJE0bflfklI1iGnB5zqUspjINcPo1yJ3wCMICGAYYCw/s96-c",
                            ApplicationKeys = new List<string>().AsEnumerable(),
                            Disabled = false,
                            Deleted = false
                        };
                        ListOfUsers.Add(pamaxieUser);
                        return;
                    }
                }
            }

            ListOfUsers.Add(new PamaxieUser()
            {
                UniqueKey = "101963629560135630792",
                UserName = "",
                FirstName = "",
                LastName = "",
                EmailAddress = "",
                EmailVerified = false,
                ProfilePictureAddress = "",
                Disabled = false,
                Deleted = true
            });
        }
    }
}