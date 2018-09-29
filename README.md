![Azure Devops](https://hsgame.visualstudio.com/UE4HorizonPlugin/_apis/build/status/HorizonFrameworkPluginDemo-CI)

public feed: nuget.org  

[![nuget.org package in feed in ](https://img.shields.io/nuget/v/UE4Editor-HorizonFrameworkDemo.svg)](https://www.nuget.org/packages/UE4Editor-HorizonFrameworkDemo/)

private feed(only for internal use): 

[![Azure Artifacts package in  feed in ](https://hsgame.feeds.visualstudio.com/_apis/public/Packaging/Feeds/d5ed5eb7-dd62-4af0-a6a4-8862be2b9f7f/Packages/170234ae-8282-419c-a715-950d0ea63479/Badge)](https://hsgame.visualstudio.com/_Packaging?feed=d5ed5eb7-dd62-4af0-a6a4-8862be2b9f7f&package=170234ae-8282-419c-a715-950d0ea63479&preferRelease=true&_a=package)


Note: 

master branch may be unstable since it is in development, please switch to tags, for example: release/4.20.0



----------------------------------------------  
How to Run Demo Project before purchase:(Only for Win64 editor build, no source code)
1. [Download nuget executable](https://www.nuget.org/downloads) and copy the exe into C:\Windows\system32\ or any place listed in your PATH environment.
2. Double click install_package_from_nuget.org.bat, and check if UE4Editor-*.dll are installed to Binaries\Win64 and Plugins\HorizonFrameworkPlugin\Binaries\Win64\
3. Double click HorizonFrameworkDemo.uproject  
----------------------------------------------

 

----------------------------------------------  
<h2 align="center">				
			HorizonFrameworkPlugin<br>
					4.20.0   <br>
			http://dorgon.horizon-studio.net  <br>
				dorgonman@hotmail.com  <br>
</h2>
----------------------------------------------  

 The goal of this plugin is to provide a general game framework that can manage WidgetBlueprints and related game logic with more organized way.

-----------------------  
System Requirements
-----------------------  
Tested UnrealEngine version: 4.18, 4.19, 4.20


-----------------------
Installation Guide
-----------------------  

Put HorizonFrameworkPlugin into YOUR_PROJECT/Plugins folder, 
and then add module to your project 
YOUR_PROJECT.Build.cs:
PublicDependencyModuleNames.AddRange(new string[] { "HorizonFramework"});

-----------------------
User Guide
-----------------------  
1. Create classes that inherited from AHorizonScene
2. Design your own Widget Blueprint.
3. Assign Widget Blueprint to HorizonScene's HorizonPlugin|Framework|UI|WidgetClass
4. Use functions in AHorizonSceneManager, UHorizonSceneManagerLibrary or UHorizonSceneManagerProxy to control HorizonScene

-----------------------
Technical Details
-----------------------  

List of Modules: HorizonFramework(Runtime), HorizonFrameworkEditor(Editor)

Intended Platform: All Platforms  

Platforms Tested: Windows

Demo Project: https://github.com/dorgonman/HorizonFrameworkDemo

DemoVideo: https://youtu.be/TQ3oFkdn2Pg

-----------------------
What does your plugin do/What is the intent of your plugin
-----------------------  

* Because UMG Widget behavior are encapsulated into HorizonScene, so we need to create classes that inherited from AHorizonScene and use funtions in AHorizonSceneManager to determine which widget we want to display in screen. For example ChangeSceneByClass will create widget assigned in HorizonScene; PushSceneByClass will add Widget on the top of other scene; PopScene will remove top widget in SceneStack from screen.

* AHorizonScene is inherited from AHorizonSceneBase with VR support that will check if game is running in VR mode, if game is running in VR mode, then plugin will use WidgetComponent to display Widget instead of calling AddToViewport.

* AHorizonTutorialSystem is a simple tutorial framework intend to create step by step task.

* UHorizonStaticMeshComponent: StaticMeshComponent that will generate dynamic material automatically.

-----------------------
Contact and Support
-----------------------  

email: dorgonman@hotmail.com


-----------------------
 Version History
-----------------------  
*4.20.0
 Refactor Source Folder

*4.19.2
	New: Param warning in HorizonScene's animation name DropDown list if param name not found
	Fix: Add WhitelistPlatform for IOS and HTML5
*4.19.0
- FIX: HorizonScene's WidgetComponent bugs in VR Mode.
- Refactor

*4.18.0
 - NEW: First Version including core features.