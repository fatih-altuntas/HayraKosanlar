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
        }
        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";
    }
}