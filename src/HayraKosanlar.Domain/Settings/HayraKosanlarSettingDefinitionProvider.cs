using Volo.Abp.Settings;

namespace HayraKosanlar.Settings
{
    public class HayraKosanlarSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(HayraKosanlarSettings.MySetting1));
        }
    }
}
