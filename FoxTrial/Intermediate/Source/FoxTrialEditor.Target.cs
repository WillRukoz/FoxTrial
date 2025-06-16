using UnrealBuildTool;

public class FoxTrialEditorTarget : TargetRules
{
	public FoxTrialEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("FoxTrial");
	}
}
