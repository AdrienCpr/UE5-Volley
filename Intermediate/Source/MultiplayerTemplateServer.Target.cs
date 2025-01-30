using UnrealBuildTool;

public class MultiplayerTemplateServerTarget : TargetRules
{
	public MultiplayerTemplateServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MultiplayerTemplate");
	}
}
