using HayraKosanlar.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HayraKosanlar.Permissions
{
    public class HayraKosanlarPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var hayraKosanlarPermissionGroup = context.AddGroup(HayraKosanlarPermissions.GroupName, L("Permission:HelpRequest"));

            var helpRequestsPermission = hayraKosanlarPermissionGroup.AddPermission(HayraKosanlarPermissions.HelpRequest.List, L("Permission:HelpRequest.List"));
            helpRequestsPermission.AddChild(HayraKosanlarPermissions.HelpRequest.Create, L("Permission:HelpRequest.Create"));
            helpRequestsPermission.AddChild(HayraKosanlarPermissions.HelpRequest.Edit, L("Permission:HelpRequest.Edit"));
            helpRequestsPermission.AddChild(HayraKosanlarPermissions.HelpRequest.ViewButton, L("Permission:HelpRequest.ViewButton"));
            helpRequestsPermission.AddChild(HayraKosanlarPermissions.HelpRequest.EditButton, L("Permission:HelpRequest.EditButton"));
            helpRequestsPermission.AddChild(HayraKosanlarPermissions.HelpRequest.SpotterDecisionView, L("Permission:HelpRequest.SpotterDecisionView"));
            helpRequestsPermission.AddChild(HayraKosanlarPermissions.HelpRequest.DistributorDecisionView, L("Permission:HelpRequest.DistributorDecisionView"));
            helpRequestsPermission.AddChild(HayraKosanlarPermissions.HelpRequest.CreateEditSelectedDistributor, L("Permission:HelpRequest.CreateEditSelectedDistributor"));
            helpRequestsPermission.AddChild(HayraKosanlarPermissions.HelpRequest.CreateEditSelectedSpotter, L("Permission:HelpRequest.CreateEditSelectedSpotter"));

            var giveAHandRequestsPermission = hayraKosanlarPermissionGroup.AddPermission(HayraKosanlarPermissions.GiveAHelpRequest.List, L("Permission:GiveAHelpRequest:List"));
            giveAHandRequestsPermission.AddChild(HayraKosanlarPermissions.GiveAHelpRequest.Create, L("Permission:GiveAHelpRequest.Create"));
            giveAHandRequestsPermission.AddChild(HayraKosanlarPermissions.GiveAHelpRequest.Edit, L("Permission:GiveAHelpRequest.Edit"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<HayraKosanlarResource>(name);
        }
    }
}
