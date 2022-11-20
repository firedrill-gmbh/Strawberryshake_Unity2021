# Implementation of StrawberryShake 13 for Unity 2021.3 LTS

## Setup
- The project includes all dependencies of the package StrawberryShake.Server. (There is a curently not working StrawberryShake.Server banch wich includes the package StrawberryShake.Server.) 
  - All packages are available as NET.Standart 2.0 and where applicable as NET.Standart 2.1.
  - The link.xml file makes sure that none of the packages are striped by Unity [Unity - Manual: Managed code stripping](https://docs.unity3d.com/Manual/ManagedCodeStripping.html).
  - The backages where copied by hand from my local nuget packeg cach as the custom unity tools for getting nuget packages all hat their issues. Future version of Unity will support nuget but this is not comming soon but is a [Unity and .NET, what’s next?](https://blog.unity.com/technology/unity-and-net-whats-next).
- The GraphQL backend URL and the auto generated files origin from an [external console project](https://github.com/firedrill-gmbh/StrawberryShake_13_Console). 

## State
- The project runs in Editor
- The project runs on Android
  - When you create a project make sure you set Android->Configuration->Internet Access from Auto to Require in the Player settings. Otherwise, you will get a "Error Unity WebException: Error: NameResolutionFailure ...". I think the reason for this has also to do with Managed code stripping but adding System.Net to the link.xml did not work.
- The project runs on iOS
  - You need to input your own appleDeveloperTeamID in the PlayerSettings before building
