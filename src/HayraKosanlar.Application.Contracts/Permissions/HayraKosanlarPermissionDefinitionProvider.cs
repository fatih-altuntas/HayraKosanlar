using HayraKosanlar.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HayraKosanlar.Permissions
{
    public class HayraKosanlarPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(HayraKosanlarPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(HayraKosanlarPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<HayraKosanlarResource>(name);
        }
    }
}
