using AskXammy.Pages;

namespace AskXammy;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        Routing.RegisterRoute(nameof(EbookOnboardingPage), typeof(EbookOnboardingPage));
    }
}