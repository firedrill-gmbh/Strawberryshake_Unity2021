# Implementation of StrawberryShake for Unity 2021.3 LTS
## Setup
- The project includes the package StrawberryShake.Transport.Http and
  all dependencies.
- All packages are available as NET.Standart 2.0 and where applicable
  as NET.Standart 2.1. The 2.1 packages are disabled for all platforms.
- The GraphQL backend url and the auto generated files origin from
  an external console project. It was built from the sample
  https://chillicream.com/docs/strawberryshake/get-started/console.
## State
- The project runs in Editor
- The project runs on Android 
  - The "InvalidOperationException: A suitable constructor for type 'Microsoft.Extensions.Http.DefaultHttpClientFactory' could not be located." was fixed by https://github.com/firedrill-gmbh/Strawberryshake_Unity2021/commit/a2d571cf55efff40f5afff60e4df86bfb0ee9dd8
  - The "Error Unity WebException: Error: NameResolutionFailure" was fixed by https://github.com/firedrill-gmbh/Strawberryshake_Unity2021/commit/726fc6fc96596661a68b022c8f37073724aef719
- The project is bronekn on iOS
  - InvalidOperationException: A suitable constructor for type 'StrawberryShake.EntityStore' could not be located.
  - Note: iOS is curently not configured for this projekct. The exception is from oure main project.
