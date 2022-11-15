using UnrealBuildTool;

public class VRTestTarget : TargetRules
{
	public VRTestTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("VRTest");
	}
}
