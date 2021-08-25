﻿using System;
using Pamaxie.Data;
using Pamaxie.Database.Design;

namespace Pamaxie.Database.Extensions.Client
{
    /// Implementation to get <see cref="IPamaxieApplication"/> data from the server
    internal class ApplicationDataService : ClientDataServiceBase<IPamaxieApplication>, IApplicationDataService
    {
        /// <inheritdoc/>
        internal ApplicationDataService(DatabaseService service)
        {
            Service = service;
        }

        /// <inheritdoc/>
        public IPamaxieApplication EnableOrDisable(IPamaxieApplication value)
        {
            throw new NotImplementedException();
        }
        
        /// <inheritdoc/>
        public bool VerifyAuthentication(IPamaxieApplication value)
        {
            throw new NotImplementedException();
        }
    }
}