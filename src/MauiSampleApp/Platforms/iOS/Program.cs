using Foundation;
using UIKit;

namespace MauiSampleApp;

public class Program
{
	private static void Main(string[] args)
	{
		UIApplication.Main(args, null, typeof(AppDelegate));
	}
}

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
