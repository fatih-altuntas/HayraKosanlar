namespace HayraKosanlar.Permissions
{
    public static class HayraKosanlarPermissions
    {
        public const string GroupName = "HayraKosanlar";
        public static class HelpRequest
        {
            public const string List = GroupName + ".List";
            public const string Create = GroupName + ".Create";
            public const string Edit = GroupName + ".Edit";
            public const string CreateEditSelectedSpotter = GroupName + ".CreateEditSelectedSpotter";
            public const string CreateEditSelectedDistributor = GroupName + ".CreateEditSelectedDistributor";

        }
        public static class GiveAHelpRequest
        {
            public const string List = GroupName + ".ListGiveAHandRequest";
            public const string Create = GroupName + ".CreateGiveAHandRequest";
            public const string Edit = GroupName + ".EditGiveAHandRequest";
        }
    }
}