using Abp.Authorization;
using BaseDeConhecimento.Authorization.Roles;
using BaseDeConhecimento.Authorization.Users;

namespace BaseDeConhecimento.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
