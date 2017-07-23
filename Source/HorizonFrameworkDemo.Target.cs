// Created by dorgon, All Rights Reserved.
// email: dorgonman@hotmail.com
// blog: dorgon.horizon-studio.net

using UnrealBuildTool;
using System.Collections.Generic;

public class HorizonFrameworkDemoTarget : TargetRules
{
	public HorizonFrameworkDemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "HorizonFrameworkDemo" } );
	}
}
