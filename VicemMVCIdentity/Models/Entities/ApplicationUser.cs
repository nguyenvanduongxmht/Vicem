using Microsoft.AspNetCore.Identity;

namespace VicemMVCIdentity.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string FullName { get; set; }
    }
}
