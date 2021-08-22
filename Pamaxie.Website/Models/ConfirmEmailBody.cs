﻿using System;
using Pamaxie.Data;

namespace Pamaxie.Website.Models
{
    public class ConfirmEmailBody : IBody
    {
        public EmailPurpose Purpose => EmailPurpose.EMAIL_CONFIRMATION;
        public DateTime Expiration { get; set; } = DateTime.UtcNow.AddDays(10);
        public IPamaxieUser User { get; }

        public ConfirmEmailBody(IPamaxieUser user)
        {
            User = user;
        }
    }
}