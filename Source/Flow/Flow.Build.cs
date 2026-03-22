// Copyright https://github.com/MothCocoon/FlowGraph/graphs/contributors
using UnrealBuildTool;

public class Flow : ModuleRules
{
	public Flow(ReadOnlyTargetRules target) : base(target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"LevelSequence"
		});

		PrivateDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"DeveloperSettings",
			"Engine",
			"GameplayAbilities", // for FGameplayTagRequirements
			"GameplayTags",
			"MovieScene",
			"MovieSceneTracks",
			"NetCore",
			"Slate",
			"SlateCore"
		});

		if (target.Type == TargetType.Editor)
		{
			PublicDependencyModuleNames.AddRange(new string[] {
				"GraphEditor",
				"MessageLog",
				"PropertyEditor",
				"SourceControl",
				"UnrealEd"
			});
		}
	}
}