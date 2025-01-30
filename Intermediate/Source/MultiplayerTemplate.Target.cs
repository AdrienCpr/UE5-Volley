using UnrealBuildTool;

public class MultiplayerTemplateTarget : TargetRules
{
	public MultiplayerTemplateTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MultiplayerTemplate");
	}
}
