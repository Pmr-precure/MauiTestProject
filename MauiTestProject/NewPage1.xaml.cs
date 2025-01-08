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
        HandlerProperties.SetDisconnectPolicy(video, HandlerDisconnectPolicy.Manual);
    }

    protected async override void OnDisappearing()
    {
        base.OnDisappearing();
    
        video.Handler?.DisconnectHandler();
       
    }

  
}