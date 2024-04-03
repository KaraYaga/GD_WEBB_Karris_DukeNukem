// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class GD_WEBB_Karris_FPSTarget : TargetRules
{
	public GD_WEBB_Karris_FPSTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "GD_WEBB_Karris_FPS" } );
	}
}
