using HayraKosanlar.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HayraKosanlar.Permissions
{
    public class HayraKosanlarPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var bookStoreGroup = context.AddGroup(HayraKosanlarPermissions.GroupName, L("Permission:HelpRequest"));

            var booksPermission = bookStoreGroup.AddPermission(HayraKosanlarPermissions.HelpRequest.List, L("Permission:List"));
            booksPermission.AddChild(HayraKosanlarPermissions.HelpRequest.Create, L("Permission:HelpRequest.Create"));
            booksPermission.AddChild(HayraKosanlarPermissions.HelpRequest.Edit, L("Permission:HelpRequest.Edit"));


            //Define your own permissions here. Example:
            //myGroup.AddPermission(HayraKosanlarPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<HayraKosanlarResource>(name);
        }
    }
}
