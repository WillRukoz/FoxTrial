using UnrealBuildTool;

public class FoxTrialClientTarget : TargetRules
{
	public FoxTrialClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("FoxTrial");
	}
}
