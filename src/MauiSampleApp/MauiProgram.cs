namespace MauiSampleApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        return MauiApp.CreateBuilder()
            .UseMauiApp<TestApp>()
            .ConfigureServices()
            .Build();
    }

    private static MauiAppBuilder ConfigureServices(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<IWebRtcTester, WebRtcTester>();
        return builder;
    }
}

public class TestApp : Application
{
    public TestApp(IWebRtcTester webRtcTester)
    {
        MainPage = new ContentPage
        {
            Content = new Label
            {
                Text = "MAUI WebRTC Test",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            },
        };

        webRtcTester.Test();
    }
}

public interface IWebRtcTester
{
    void Test();
}