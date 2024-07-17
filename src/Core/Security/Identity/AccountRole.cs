using Core.Domain.Contracts;

using Microsoft.AspNetCore.Identity;

namespace Core.Security.Identity
{
    public class AccountRole : IdentityRole, IAuditableEntity<string>
    {
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public virtual ICollection<AccountRoleClaim> RoleClaims { get; set; }

        public AccountRole() : base()
        {
            RoleClaims = new HashSet<AccountRoleClaim>();
        }

        public AccountRole(string roleName, string roleDescription = null) : base(roleName)
        {
            RoleClaims = new HashSet<AccountRoleClaim>();
            Description = roleDescription;
        }
    }
}