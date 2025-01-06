namespace MauiTestProject
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public string CurrentState { get; set; } = "Start";
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
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

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(NewPage1));
            
        }
    }

}
