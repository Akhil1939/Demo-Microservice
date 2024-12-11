using Microsoft.AspNetCore.Identity;

namespace IStore.Services.AuthApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
