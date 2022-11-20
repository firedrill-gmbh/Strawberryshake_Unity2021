# Implementation of StrawberryShake 13 for Unity 2021 LTS
## Setup
- The project includes the package StrawberryShake.Server and all dependencies.
  - All dependency packages of StrawberryShake.Server packages are where possible as NET.Standart 2.1 .dll and otherwise as NET.Standart 2.0 .dll.
  - The StrawberryShake.Server package itself does not work as some dll. can't be loaded. It also contained many duplicated .dlls, which is not supported by Unity. Because of this all folders in strawberryshake.server\13.0.0-preview.80\tools\ except de\ where removed and some .dll in strawberryshake.server\13.0.0-preview.80\tools\ where set excluded from all platforms.
  - The link.xml file makes sure that none of the packages are striped by Unity [Unity - Manual: Managed code stripping](https://docs.unity3d.com/Manual/ManagedCodeStripping.html).
  - The packages were copied by hand from my local nuget package cache as the custom unity tools for getting nuget packages all hat their issues. Future version of Unity will support nuget but this is not coming soon but is a [Unity and .NET, what’s next?](https://blog.unity.com/technology/unity-and-net-whats-next).
- The GraphQL backend URL and the auto generated files origin from an [external console project](https://github.com/firedrill-gmbh/StrawberryShake_13_Console).
