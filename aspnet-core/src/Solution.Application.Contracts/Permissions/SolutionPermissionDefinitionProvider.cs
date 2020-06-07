using Solution.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Solution.Permissions
{
    public class SolutionPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(SolutionPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(SolutionPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SolutionResource>(name);
        }
    }
}
