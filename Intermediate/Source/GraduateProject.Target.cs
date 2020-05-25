using UnrealBuildTool;

public class GraduateProjectTarget : TargetRules
{
	public GraduateProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("GraduateProject");
	}
}
