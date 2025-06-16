using UnrealBuildTool;

public class FoxTrialServerTarget : TargetRules
{
	public FoxTrialServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("FoxTrial");
	}
}
