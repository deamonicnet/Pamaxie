﻿using System;
using System.Collections.Generic;
using Pamaxie.Data;
using Pamaxie.Database.Design;

namespace Pamaxie.Database.Extensions.Client
{
    /// Implementation to get <see cref="IPamaxieUser"/> data from the server
    internal class UserDataService : ClientDataServiceBase<IPamaxieUser>, IUserDataService
    {
        /// <inheritdoc/>
        internal UserDataService(PamaxieDataContext dataContext, DatabaseService service)
        {
            DataContext = dataContext;
            Service = service;
        }
        
        /// <inheritdoc/>
        public IEnumerable<IPamaxieApplication> GetAllApplications(IPamaxieUser value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public bool VerifyEmail(IPamaxieUser value)
        {
            throw new NotImplementedException();
        }
    }
}