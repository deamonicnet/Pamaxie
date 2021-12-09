﻿using Pamaxie.Authentication;
using System.Collections.Generic;

using Test.Base;
using Xunit;
using Xunit.Abstractions;

namespace Test.Pamaxie.Jwt_Test
{
    /// <summary>
    /// Testing class for <see cref="TokenGenerator"/>
    /// </summary>
    public sealed class TokenGeneratorTest : TestBase
    {
        /// <summary>
        /// <inheritdoc cref="MemberData.AllUsers"/>
        /// </summary>
        public static IEnumerable<object[]> AllUserKeys => MemberData.AllUserKeys;

        public TokenGeneratorTest(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
        }

        /// <summary>
        /// Test for creating a token through <see cref="TokenGenerator.CreateToken"/>
        /// </summary>
        /// <param name="userKey">The user key from inlined data</param>
        [Theory]
        [MemberData(nameof(AllUserKeys))]
        public void CreateToken(string userKey)
        {
            //Arrange
            JwtTokenGenerator generator = new JwtTokenGenerator(Configuration);

            //Act
            JwtToken authToken = generator.CreateToken(userKey);

            //Assert
            Assert.NotNull(authToken);
            Assert.False(string.IsNullOrWhiteSpace(authToken.Token));
            TestOutputHelper.WriteLine("Token: {0}", authToken.Token);
            TestOutputHelper.WriteLine("Expires at {0:R}", authToken.ExpiresAtUTC.ToLocalTime());
        }

        /// <summary>
        /// Test for decrypting a JWT bearer token through <see cref="TokenGenerator.GetUserKey"/>
        /// </summary>
        /// <param name="expectedUserKey">The expected user key from inlined data</param>
        [Theory]
        [MemberData(nameof(AllUserKeys))]
        public void GetUserKey(string expectedUserKey)
        {
            //Arrange
            JwtTokenGenerator generator = new JwtTokenGenerator(Configuration);
            JwtToken authToken = generator.CreateToken(expectedUserKey);
            Assert.NotNull(authToken);

            //Act
            string userKey = JwtTokenGenerator.GetUserKey(authToken.Token);

            //Assert
            Assert.False(string.IsNullOrWhiteSpace(userKey));
            TestOutputHelper.WriteLine("Actual user key {0}", userKey);
            TestOutputHelper.WriteLine("Expected user key {0}", expectedUserKey);
            Assert.Equal(expectedUserKey, userKey);
        }
    }
}