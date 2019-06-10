// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class ProjCoreCppNewEditorTarget : TargetRules
{
	public ProjCoreCppNewEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "ProjCoreCppNew" } );
	}
}
