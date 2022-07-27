# Implementation of StrawberryShake 13 for Unity 2021.3 LTS

## Setup
- The project includes the package StrawberryShake.Transport.Http and
  all dependencies.
  - All packages are available as NET.Standart 2.0 and where applicable as NET.Standart 2.1. Where 2.1 packages exist the 2.0 packages are disabled for all platforms. I left them there in case you want NET.Standart 2.0 compatibility, e.g.: older for unity versions.
  - The link.xml file makes sure that none of the packages are striped by Unity [Unity - Manual: Managed code stripping](https://docs.unity3d.com/Manual/ManagedCodeStripping.html).
- The GraphQL backend URL and the auto generated files origin from an external console project. It was built from the sample
  https://chillicream.com/docs/strawberryshake/get-started/console.

## State
- The project runs in Editor
- The project runs on Android
  - When you create a project make sure you set Android->Configuration->Internet Access from Auto to Require in the Player settings. Otherwise, you will get a "Error Unity WebException: Error: NameResolutionFailure ..." and don't know what to do as I did^^. I think the reason for this has also to do with Managed code stripping but adding System.Net to the link.xml did not work.
- The project runs on iOS
  - You need to input your own appleDeveloperTeamID in the PlayerSettings before building
