using AskXammy.Pages;

namespace AskXammy;

public partial class MainPage : ContentPage
{
    

    public MainPage() => InitializeComponent();


    private void GotoEbookOnboarding_OnClicked(object? sender, EventArgs e) 
        => Shell.Current.GoToAsync(nameof(EbookOnboardingPage));
}