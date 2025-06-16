using UnrealBuildTool;

public class FoxTrialTarget : TargetRules
{
	public FoxTrialTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("FoxTrial");
	}
}
