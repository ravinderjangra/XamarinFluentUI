#load "common.cake"

var TARGET = Argument ("t", Argument ("target", "Default"));

// iOS Build setup

var IOS_PODS = new List<string> {
	"platform :ios, '11.4'",
	"install! 'cocoapods', :integrate_targets => false",
	"use_frameworks!",
	"target 'Xamarin' do",
	"pod 'MicrosoftFluentUI', '0.0.9'",
	"end",
};

var buildSpec = new BuildSpec {

	Libs = new ISolutionBuilder [] {
		new IOSSolutionBuilder {
			SolutionPath = "../FluentUI.iOS/FluentUI.iOS.csproj",
			Configuration = "Release",
			Platform = "Any CPU",
			OutputFiles = new [] { 
				new OutputFileCopy {
					FromFile = "./FluentUI.iOS/FluentUI.iOS/bin/Release/FluentUIComponents.dll",
				}
			}
		},
	},
};

Task ("ios-externals")
	.WithCriteria (!FileExists ("./externals/FluentUI.framework"))
	.Does (() => 
{
	EnsureDirectoryExists ("./externals");

	if (CocoaPodVersion () < new System.Version (1, 0))
		IOS_PODS.RemoveAt (1);

	FileWriteLines ("./externals/Podfile", IOS_PODS.ToArray ());

	CocoaPodInstall ("./externals");

	BuildDynamicXCode ("./Pods/Pods.xcodeproj", "MicrosoftFluentUI", "FluentUI", "./externals/", TargetOS.iOS);
});

Task ("ios-clean")
	.Does (() => 
{
	if (DirectoryExists ("./externals/"))
		DeleteDirectory ("./externals/", true);
});

SetupXamarinBuildTasks (buildSpec, Tasks, Task);


// Android Build Setup
var AAR_VERSION = "0.0.1";
var AAR_URL = $"https://jcenter.bintray.com/com/microsoft/fluentui/FluentUIAndroid/{AAR_VERSION}/FluentUIAndroid-{AAR_VERSION}.aar";

Task ("android-externals")
	.WithCriteria (!FileExists ("./externals/FluentUIAndroid.aar"))
	.Does (() =>
{
	EnsureDirectoryExists ("./externals");
	// Download Dependencies
	DownloadFile (AAR_URL, "./externals/FluentUIAndroid.aar");
});

RunTarget (TARGET);
