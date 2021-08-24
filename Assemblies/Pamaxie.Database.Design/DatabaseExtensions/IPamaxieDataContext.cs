﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamaxie.Database.Extensions.DatabaseExtensions
{
    public interface IPamaxieDataContext
    {
        /// <summary>
        /// Creates a Connection string through the options reached in.
        /// </summary>
        /// <returns></returns>
        public string ConnectionString();

        /// <summary>
        /// Defines the available instances for data connection
        /// </summary>
        public string DataInstances { get; }

        /// <summary>
        /// Defines the password to use for the redis instances
        /// </summary>
        public string Password { get; }

        /// <summary>
        /// How many attempts should be made to connect to the database
        /// </summary>
        public int ReconnectionAttempts { get; }
    }
}
