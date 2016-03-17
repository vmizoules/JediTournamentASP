using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JediWebSiteApplication.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace JediWebSiteApplication.Models
{
    public class CustomApplicationUser : ApplicationUser
    {
        public virtual ICollection<IdentityUserClaim> Claims { get; set; }
        public virtual ICollection<IdentityUserLogin> Logins { get; set; }
        public virtual ICollection<IdentityUserRole> Roles { get; set; }

        public CustomApplicationUser()
        {
            this.Claims = null;
            this.Logins = null;
            this.Roles = null;
        }

        public CustomApplicationUser(ApplicationUser user)
            :this()
        {
            this.Id = user.Id;
            this.UserName = user.UserName;
            this.PasswordHash = user.PasswordHash;
            // TODO Add it
        }
    }
}