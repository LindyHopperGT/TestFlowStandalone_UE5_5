// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FlowStandalone : ModuleRules
{
	public FlowStandalone(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "NavigationSystem", "AIModule", "Niagara", "EnhancedInput" });
    }
}
