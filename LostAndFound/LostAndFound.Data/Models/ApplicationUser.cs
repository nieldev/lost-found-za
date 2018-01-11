using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace LostAndFound.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public Contact Contact { get; set; }
        public string SavcNumber { get; set; }
        public string NpoNumber { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            if (!string.IsNullOrWhiteSpace(this.SavcNumber))
                userIdentity.AddClaim(new Claim("savc-number", this.SavcNumber));
            if (!string.IsNullOrWhiteSpace(this.NpoNumber))
                userIdentity.AddClaim(new Claim("npo-number", this.NpoNumber));

            return userIdentity;
        }
    }
}
