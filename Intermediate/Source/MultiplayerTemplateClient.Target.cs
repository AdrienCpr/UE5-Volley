using UnrealBuildTool;

public class MultiplayerTemplateClientTarget : TargetRules
{
	public MultiplayerTemplateClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MultiplayerTemplate");
	}
}
