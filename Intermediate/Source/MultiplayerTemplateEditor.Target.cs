using UnrealBuildTool;

public class MultiplayerTemplateEditorTarget : TargetRules
{
	public MultiplayerTemplateEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MultiplayerTemplate");
	}
}
