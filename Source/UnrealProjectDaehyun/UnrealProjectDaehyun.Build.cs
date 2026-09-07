// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UnrealProjectDaehyun : ModuleRules
{
	public UnrealProjectDaehyun(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"UnrealProjectDaehyun",
			"UnrealProjectDaehyun/Variant_Platforming",
			"UnrealProjectDaehyun/Variant_Platforming/Animation",
			"UnrealProjectDaehyun/Variant_Combat",
			"UnrealProjectDaehyun/Variant_Combat/AI",
			"UnrealProjectDaehyun/Variant_Combat/Animation",
			"UnrealProjectDaehyun/Variant_Combat/Gameplay",
			"UnrealProjectDaehyun/Variant_Combat/Interfaces",
			"UnrealProjectDaehyun/Variant_Combat/UI",
			"UnrealProjectDaehyun/Variant_SideScrolling",
			"UnrealProjectDaehyun/Variant_SideScrolling/AI",
			"UnrealProjectDaehyun/Variant_SideScrolling/Gameplay",
			"UnrealProjectDaehyun/Variant_SideScrolling/Interfaces",
			"UnrealProjectDaehyun/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
