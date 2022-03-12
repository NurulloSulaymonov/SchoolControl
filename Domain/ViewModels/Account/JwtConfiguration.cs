using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ViewModels.Account
{
    public class JwtConfiguration
    {
        public string  Key { get; set; }
        public string  Issuer { get; set; }
        public string  Subject { get; set; }
        public string  Audience { get; set; }
    }
}
