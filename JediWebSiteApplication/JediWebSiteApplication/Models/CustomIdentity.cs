using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Claims;

namespace JediWebSiteApplication.Models
{
    public class CustomIdentity : ClaimsIdentity
    {

        public virtual bool IsAuthenticated { get; set; }
        public virtual string Name { get; set; }

        public CustomIdentity(IEnumerable<Claim> claims, string authenticationType)
            : base(claims, authenticationType)
        {
            
        }

    }
}