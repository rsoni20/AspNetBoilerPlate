using Abp.Authorization;
using ME.Authorization.Roles;
using ME.Authorization.Users;

namespace ME.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
