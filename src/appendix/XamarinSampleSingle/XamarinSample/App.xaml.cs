using XamarinSample.Services;

namespace XamarinSample; 

public partial class App : Application
{

    public App()
    {
        InitializeComponent();
        DependencyService.Register<MockDataStore>();
        MainPage = new AppShell();
    }
}
