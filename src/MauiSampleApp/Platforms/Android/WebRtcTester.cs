using WebRtc.Android;

namespace MauiSampleApp;

public class WebRtcTester : IWebRtcTester
{
    public void Test()
    {
        PeerConnection.IceServer
            .InvokeBuilder("stun:stun.l.google.com:19302")!
            .CreateIceServer();
    }
}