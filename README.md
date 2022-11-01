# MAUI.WebRTC.Demo
Demo project to try WebRTC native bindings in .net MAUI.
There are two projects with Xamarin bindings
- https://github.com/melihercan/WebRTCme
- https://github.com/dmariogatto/xamarin-webrtc

Binding libraries are based on https://github.com/dmariogatto/xamarin-webrtc

How to build via CLI from windows:
- dotnet workload install maui-android maui-ios
- On remote mac: dotnet workload install maui-ios
- Check that versions of workloads are similar othewise reinstall with updated workload manifest
- cd \src\MauiSampleApp
- dotnet build -f:net6.0-android
- dotnet build -f:net6.0-ios /p:ServerAddress={remote mac ip} /p:ServerUser={mac user name} /p:ServerPassword={mac user pw} /p:TcpPort=58181

## Status
### Android
Android working perfectly without any modifications from CLI and VS.

### iOS
iOS ApiDefinitions.cs was modified in order to complie:
- AutoGeneratedName = true - removed
- [iOS(10, 0)] - commented
- new RTCVideoCodecInfo[] SupportedCodecs { get; } - new added

#### Update ios workload 16.0.523
iOS working perfectly if compiled on mac os.
On windows it is failing with hundreds of similar errors for all Microsoft.iOS classes used in api definitions file:
```
C:\Program Files\dotnet\packs\Microsoft.iOS.Sdk\16.0.523\tools\msbuild\iOS\Xamarin.Shared.targets(1640,3): error CS0433: The type 'ExportAttribute' exists in both 'Microsoft.iOS, Version=16.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065' and 'Microsoft.iOS, Version=15.4.300.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065' [C:\XXX\src\WebRtc.iOS\WebRtc.iOS.csproj]
```
As I understand msbuild copies all referenced libraries including Microsoft.iOS.dll to remote mac. Looks like build conflicts between original sdk libraries and copied sdk libraries.

Probably issue discribed in https://github.com/xamarin/xamarin-macios/issues/16001 is still present.

Feel free to suggest any solutions or create PR's from forks. I will get back here time to time and try to fix iOS bindings or check if it was fixed by .net team.
