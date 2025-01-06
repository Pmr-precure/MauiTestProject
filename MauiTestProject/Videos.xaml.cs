namespace MauiTestProject;

public partial class Videos : ContentPage
{
	public Videos()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        HandlerProperties.SetDisconnectPolicy(video, HandlerDisconnectPolicy.Manual);
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        video.Handler?.DisconnectHandler();
        video.DisconnectHandlers();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		App.Current.Windows[0].Page = new NewPage1();
    }
}