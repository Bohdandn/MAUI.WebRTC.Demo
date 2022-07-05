using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace WebRtc.iOS
{
	[Native]
	public enum RTCVideoRotation : long
	{
		RTCVideoRotation_0 = 0,
		RTCVideoRotation_90 = 90,
		RTCVideoRotation_180 = 180,
		RTCVideoRotation_270 = 270
	}

	[Native]
	public enum RTCFrameType : ulong
	{
		EmptyFrame = 0,
		AudioFrameSpeech = 1,
		AudioFrameCN = 2,
		VideoFrameKey = 3,
		VideoFrameDelta = 4
	}

	[Native]
	public enum RTCVideoContentType : ulong
	{
		Unspecified,
		Screenshare
	}

	[Native]
	public enum RTCLoggingSeverity : long
	{
		Verbose,
		Info,
		Warning,
		Error,
		None
	}

	//static class CFunctions
	//{
	//	// extern void RTCLogEx (RTCLoggingSeverity severity, NSString *log_string) __attribute__((visibility("default")));
	//	[DllImport("__Internal")]
	//	[Verify(PlatformInvoke)]
	//	static extern void RTCLogEx(RTCLoggingSeverity severity, NSString log_string);

	//	// extern void RTCSetMinDebugLogLevel (RTCLoggingSeverity severity) __attribute__((visibility("default")));
	//	[DllImport("__Internal")]
	//	[Verify(PlatformInvoke)]
	//	static extern void RTCSetMinDebugLogLevel(RTCLoggingSeverity severity);

	//	// extern NSString * RTCFileName (const char *filePath) __attribute__((visibility("default")));
	//	[DllImport("__Internal")]
	//	[Verify(PlatformInvoke)]
	//	static extern unsafe NSString RTCFileName(sbyte* filePath);

	//	// extern void RTCInitFieldTrialDictionary (NSDictionary<NSString *,NSString *> *fieldTrials) __attribute__((visibility("default")));
	//	[DllImport("__Internal")]
	//	[Verify(PlatformInvoke)]
	//	static extern void RTCInitFieldTrialDictionary(NSDictionary<NSString, NSString> fieldTrials);

	//	// extern void RTCEnableMetrics () __attribute__((visibility("default")));
	//	[DllImport("__Internal")]
	//	[Verify(PlatformInvoke)]
	//	static extern void RTCEnableMetrics();

	//	// extern NSArray<RTCMetricsSampleInfo *> * RTCGetAndResetMetrics () __attribute__((visibility("default")));
	//	[DllImport("__Internal")]
	//	[Verify(PlatformInvoke)]
	//	static extern RTCMetricsSampleInfo[] RTCGetAndResetMetrics();

	//	// extern BOOL RTCInitializeSSL () __attribute__((visibility("default")));
	//	[DllImport("__Internal")]
	//	[Verify(PlatformInvoke)]
	//	static extern bool RTCInitializeSSL();

	//	// extern BOOL RTCCleanupSSL () __attribute__((visibility("default")));
	//	[DllImport("__Internal")]
	//	[Verify(PlatformInvoke)]
	//	static extern bool RTCCleanupSSL();

	//	// extern void RTCSetupInternalTracer () __attribute__((visibility("default")));
	//	[DllImport("__Internal")]
	//	[Verify(PlatformInvoke)]
	//	static extern void RTCSetupInternalTracer();

	//	// extern BOOL RTCStartInternalCapture (NSString *filePath) __attribute__((visibility("default")));
	//	[DllImport("__Internal")]
	//	[Verify(PlatformInvoke)]
	//	static extern bool RTCStartInternalCapture(NSString filePath);

	//	// extern void RTCStopInternalCapture () __attribute__((visibility("default")));
	//	[DllImport("__Internal")]
	//	[Verify(PlatformInvoke)]
	//	static extern void RTCStopInternalCapture();

	//	// extern void RTCShutdownInternalTracer () __attribute__((visibility("default")));
	//	[DllImport("__Internal")]
	//	[Verify(PlatformInvoke)]
	//	static extern void RTCShutdownInternalTracer();
	//}

	[Native]
	public enum RTCVideoCodecMode : ulong
	{
		RealtimeVideo,
		Screensharing
	}

	[Native]
	public enum RTCH264PacketizationMode : ulong
	{
		NonInterleaved = 0,
		SingleNalUnit
	}

	[Native]
	public enum RTCH264Profile : ulong
	{
		ConstrainedBaseline,
		Baseline,
		Main,
		ConstrainedHigh,
		High
	}

	[Native]
	public enum RTCH264Level : ulong
	{
		RTCH264Level1_b = 0,
		RTCH264Level1 = 10,
		RTCH264Level1_1 = 11,
		RTCH264Level1_2 = 12,
		RTCH264Level1_3 = 13,
		RTCH264Level2 = 20,
		RTCH264Level2_1 = 21,
		RTCH264Level2_2 = 22,
		RTCH264Level3 = 30,
		RTCH264Level3_1 = 31,
		RTCH264Level3_2 = 32,
		RTCH264Level4 = 40,
		RTCH264Level4_1 = 41,
		RTCH264Level4_2 = 42,
		RTCH264Level5 = 50,
		RTCH264Level5_1 = 51,
		RTCH264Level5_2 = 52
	}

	[Native]
	public enum RTCDispatcherQueueType : long
	{
		Main,
		CaptureSession,
		AudioSession
	}

	[Native]
	public enum RTCDeviceType : long
	{
		Unknown,
		IPhone1G,
		IPhone3G,
		IPhone3GS,
		IPhone4,
		IPhone4Verizon,
		IPhone4S,
		IPhone5GSM,
		IPhone5GSM_CDMA,
		IPhone5CGSM,
		IPhone5CGSM_CDMA,
		IPhone5SGSM,
		IPhone5SGSM_CDMA,
		IPhone6Plus,
		IPhone6,
		IPhone6S,
		IPhone6SPlus,
		IPhone7,
		IPhone7Plus,
		IPhoneSE,
		IPhone8,
		IPhone8Plus,
		IPhoneX,
		IPhoneXS,
		IPhoneXSMax,
		IPhoneXR,
		IPodTouch1G,
		IPodTouch2G,
		IPodTouch3G,
		IPodTouch4G,
		IPodTouch5G,
		IPodTouch6G,
		IPad,
		IPad2Wifi,
		IPad2GSM,
		IPad2CDMA,
		IPad2Wifi2,
		IPadMiniWifi,
		IPadMiniGSM,
		IPadMiniGSM_CDMA,
		IPad3Wifi,
		IPad3GSM_CDMA,
		IPad3GSM,
		IPad4Wifi,
		IPad4GSM,
		IPad4GSM_CDMA,
		IPad5,
		IPad6,
		IPadAirWifi,
		IPadAirCellular,
		IPadAirWifiCellular,
		IPadAir2,
		IPadMini2GWifi,
		IPadMini2GCellular,
		IPadMini2GWifiCellular,
		IPadMini3,
		IPadMini4,
		IPadPro9Inch,
		IPadPro12Inch,
		IPadPro12Inch2,
		IPadPro10Inch,
		Simulatori386,
		Simulatorx86_64
	}

	[Native]
	public enum RTCSourceState : long
	{
		Initializing,
		Live,
		Ended,
		Muted
	}

	[Native]
	public enum RTCMediaStreamTrackState : long
	{
		Live,
		Ended
	}

	[Native]
	public enum RTCIceTransportPolicy : long
	{
		None,
		Relay,
		NoHost,
		All
	}

	[Native]
	public enum RTCBundlePolicy : long
	{
		Balanced,
		MaxCompat,
		MaxBundle
	}

	[Native]
	public enum RTCRtcpMuxPolicy : long
	{
		Negotiate,
		Require
	}

	[Native]
	public enum RTCTcpCandidatePolicy : long
	{
		Enabled,
		Disabled
	}

	[Native]
	public enum RTCCandidateNetworkPolicy : long
	{
		All,
		LowCost
	}

	[Native]
	public enum RTCContinualGatheringPolicy : long
	{
		Once,
		Continually
	}

	[Native]
	public enum RTCEncryptionKeyType : long
	{
		Rsa,
		Ecdsa
	}

	[Native]
	public enum RTCSdpSemantics : long
	{
		PlanB,
		UnifiedPlan
	}

	[Native]
	public enum RTCDataChannelState : long
	{
		Connecting,
		Open,
		Closing,
		Closed
	}

	[Native]
	public enum RTCTlsCertPolicy : ulong
	{
		Secure,
		InsecureNoCheck
	}

	[Native]
	public enum RTCSignalingState : long
	{
		Stable,
		HaveLocalOffer,
		HaveLocalPrAnswer,
		HaveRemoteOffer,
		HaveRemotePrAnswer,
		Closed
	}

	[Native]
	public enum RTCIceConnectionState : long
	{
		New,
		Checking,
		Connected,
		Completed,
		Failed,
		Disconnected,
		Closed,
		Count
	}

	[Native]
	public enum RTCPeerConnectionState : long
	{
		New,
		Connecting,
		Connected,
		Disconnected,
		Failed,
		Closed
	}

	[Native]
	public enum RTCIceGatheringState : long
	{
		New,
		Gathering,
		Complete
	}

	[Native]
	public enum RTCStatsOutputLevel : long
	{
		Standard,
		Debug
	}

	[Native]
	public enum RTCRtpMediaType : long
	{
		Audio,
		Video,
		Data
	}

	[Native]
	public enum RTCRtpTransceiverDirection : long
	{
		SendRecv,
		SendOnly,
		RecvOnly,
		Inactive
	}

	[Native]
	public enum RTCSdpType : long
	{
		Offer,
		PrAnswer,
		Answer
	}

	[Native]
	public enum RTCFileLoggerSeverity : ulong
	{
		Verbose,
		Info,
		Warning,
		Error
	}

	[Native]
	public enum RTCFileLoggerRotationType : ulong
	{
		Call,
		App
	}

	[Native]
	public enum RTCPriority : long
	{
		RTCPriorityVeryLow,
		RTCPriorityLow,
		RTCPriorityMedium,
		RTCPriorityHigh
	}
}
