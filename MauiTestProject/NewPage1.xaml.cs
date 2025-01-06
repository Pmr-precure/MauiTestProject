namespace MauiTestProject;

public partial class NewPage1 : ContentPage
{
    public string CurrentState { get; set; } = "Start";
    public NewPage1()
	{
		InitializeComponent();
        BindingContext = this;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
       // HandlerProperties.SetDisconnectPolicy(video, HandlerDisconnectPolicy.Manual);
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        //video.Handler?.DisconnectHandler();
        //video.DisconnectHandlers();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        MainThread.BeginInvokeOnMainThread(() => App.Current.Windows[0].Page = new AppShell());
    }
}