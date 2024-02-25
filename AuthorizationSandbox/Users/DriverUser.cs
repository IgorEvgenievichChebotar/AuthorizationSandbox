using Microsoft.AspNetCore.Identity;

namespace AuthorizationSandbox.Users;

public class DriverUser : IdentityUser
{
    public string? Organization { get; set; }
    public virtual ICollection<IdentityUserClaim<string>>? Claims { get; set; }
    public virtual ICollection<IdentityUserRole<string>>? UserRoles { get; set; }
}