

using UnrealBuildTool;
using System.Collections.Generic;

public class test_TPSTarget : TargetRules
{
	public test_TPSTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "test_TPS" } );
	}
}
