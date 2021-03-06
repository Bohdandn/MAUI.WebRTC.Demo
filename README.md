# MAUI.WebRTC.Demo
Demo project to try WebRTC native bindings in .net MAUI.
There are two projects with Xamarin bindings
- https://github.com/melihercan/WebRTCme
- https://github.com/dmariogatto/xamarin-webrtc

Binding libraries are based on https://github.com/dmariogatto/xamarin-webrtc

## Status
### Android
Android working perfectly without any modifications.

### iOS
iOS ApiDefinitions.cs was modified in order to complie:
- AutoGeneratedName = true - removed
- [iOS(10, 0)] - commented
- new RTCVideoCodecInfo[] SupportedCodecs { get; } - new added

Build of WebRtc.iOS on Windows with mac build host succeeds but outputs small 304KB size dll with all bindings and framework separately in "WebRtc.iOS.resources" directory, MAUI app doesn't see it's classes. Compilation of MAUI app with frameworks from both sources fails with:
```
C:\Program Files\dotnet\packs\Microsoft.iOS.Windows.Sdk\15.4.414\tools\msbuild\iOS\Xamarin.iOS.Common.After.targets(327,3): warning MT1302: Could not extract the native library 'WebRTC.framework' from '/Users/username/Library/Caches/Xamarin/mtbs/builds/MauiSampleApp/609541de2501516f3dc9d3e7c3ac45d11100f8ea426a3434038258fdadaa92b7/obj/Debug/net6.0-ios/ios-arm64/linker-cache/WebRTC.framework.zip'. Please ensure the native library was properly embedded in the managed assembly (if the assembly was built using a binding project, the native library must be included in the project, and its Build Action must be 'ObjcBindingNativeLibrary').

C:\Program Files\dotnet\packs\Microsoft.iOS.Windows.Sdk\15.4.414\tools\msbuild\iOS\Xamarin.iOS.Common.After.targets(327,3): error IL7000: An error occured while executing the custom linker steps. Please review the build log for more information.

C:\Program Files\dotnet\packs\Microsoft.iOS.Windows.Sdk\15.4.414\tools\msbuild\iOS\Xamarin.iOS.Common.After.targets(327,3): error MT0140: File '/Users/username/Library/Caches/Xamarin/mtbs/builds/MauiSampleApp/609541de2501516f3dc9d3e7c3ac45d11100f8ea426a3434038258fdadaa92b7/obj/Debug/net6.0-ios/ios-arm64/linker-cache/WebRTC.framework/WebRTC' is not a valid framework.

C:\Program Files\dotnet\packs\Microsoft.iOS.Windows.Sdk\15.4.414\tools\msbuild\iOS\Xamarin.iOS.Common.After.targets(327,3): error MT2342: The linker step 'Extract Binding Libraries' failed during processing: File '/Users/username/Library/Caches/Xamarin/mtbs/builds/MauiSampleApp/609541de2501516f3dc9d3e7c3ac45d11100f8ea426a3434038258fdadaa92b7/obj/Debug/net6.0-ios/ios-arm64/linker-cache/WebRTC.framework/WebRTC' is not a valid framework.

C:\Program Files\dotnet\packs\Microsoft.iOS.Windows.Sdk\15.4.414\tools\msbuild\iOS\Xamarin.iOS.Common.After.targets(368,3): error MSB3371: The file "obj\Debug\net6.0-ios\ios-arm64\linked\Link.semaphore" cannot be created. Could not find a part of the path 'C:\Users\username\Documents\Projects\WebRtc\src\MauiSampleApp\obj\Debug\net6.0-ios\ios-arm64\linked\Link.semaphore'.
```

Feel free to suggest any solutions or create PR's from forks. I will get back here time to time and try to fix iOS bindings or check if it was fixed by .net team.

iOS issue seems to be fixed - https://github.com/xamarin/xamarin-macios/issues/15289
