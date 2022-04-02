﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaCore.Application.Contracts.Email
{
    public interface IEmailService
    {
        Task SendEmailAsync(string templateName, string recipientEmailAddress, string recipientFullName, string bcc, Dictionary<string, string> parameters);
    }
}
