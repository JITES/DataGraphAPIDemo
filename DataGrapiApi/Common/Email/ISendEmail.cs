using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace DataGrapiApi.Common.Email
{
    public interface ISendEmail
    {
        string Send(EmailModel emailModel);
    }

    
}
