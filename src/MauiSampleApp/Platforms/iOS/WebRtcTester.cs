using WebRtc.iOS;

namespace MauiSampleApp;

public class WebRtcTester : IWebRtcTester
{
    public void Test()
    {
        var _ = new RTCIceServer(new[] { "stun:stun.l.google.com:19302" });
    }
}