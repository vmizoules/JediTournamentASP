using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Claims;

namespace JediWebSiteApplication.Models
{
    public class CustomIdentity : ClaimsIdentity
    {
        public CustomIdentity(IEnumerable<Claim> claims, string authenticationType)
            : base(claims, authenticationType)
        {
        }
    }
}