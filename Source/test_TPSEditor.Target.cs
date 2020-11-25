

using UnrealBuildTool;
using System.Collections.Generic;

public class test_TPSEditorTarget : TargetRules
{
	public test_TPSEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "test_TPS" } );
	}
}
