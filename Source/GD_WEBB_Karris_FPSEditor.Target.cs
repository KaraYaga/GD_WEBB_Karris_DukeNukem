// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class GD_WEBB_Karris_FPSEditorTarget : TargetRules
{
	public GD_WEBB_Karris_FPSEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "GD_WEBB_Karris_FPS" } );
	}
}
