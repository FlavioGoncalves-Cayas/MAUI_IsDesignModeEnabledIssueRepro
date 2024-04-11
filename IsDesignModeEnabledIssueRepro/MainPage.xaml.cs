namespace IsDesignModeEnabledIssueRepro;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        Heading.Text = $"DesignMode.IsDesignModeEnabled = {DesignMode.IsDesignModeEnabled}";
    }
}