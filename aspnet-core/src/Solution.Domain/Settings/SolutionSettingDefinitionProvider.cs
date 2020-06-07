using Volo.Abp.Settings;

namespace Solution.Settings
{
    public class SolutionSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(SolutionSettings.MySetting1));
        }
    }
}
