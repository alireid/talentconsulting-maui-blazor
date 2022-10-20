using Foundation;

namespace TalentConsulting.MauiBlazor;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => TalentConsultingProgram.CreateMauiApp();
}
