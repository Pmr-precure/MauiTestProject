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
        
        }
        protected override void OnDisappearing()
        {
            
            base.OnDisappearing();
  
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(NewPage1));
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var memoryFiller = new MemoryFiller();

            // Start memory filling (simulate continuous memory pressure)
            memoryFiller.StartFillingMemory();
        }
    }
    public class MemoryFiller
    {
        private CancellationTokenSource _cancellationTokenSource;

        // Method to start continuously filling up memory
        public void StartFillingMemory()
        {
            // Create a CancellationTokenSource to cancel the task later
            _cancellationTokenSource = new CancellationTokenSource();

            // Start the memory-filling task
            Task.Run(() => FillMemoryContinuously(_cancellationTokenSource.Token));
        }

        // Method to continuously allocate memory and simulate GC pressure
        private void FillMemoryContinuously(CancellationToken cancellationToken)
        {
            var largeList = new List<byte[]>();

            while (!cancellationToken.IsCancellationRequested)
            {
                // Allocate a large array (e.g., 10MB per iteration)
                largeList.Add(new byte[10 * 1024 * 1024]); // 10MB array

                // Simulate doing work and causing memory pressure
                // Optionally, you could also perform some non-blocking work here if needed

                Console.WriteLine("Memory allocated...");

                // Introduce a slight delay (optional, to simulate work)
                Thread.Sleep(1000); // Sleep for 100ms
            }

            Console.WriteLine("Memory filling stopped.");
        }

        // Method to stop the memory-filling operation
        public void StopFillingMemory()
        {
            if (_cancellationTokenSource != null)
            {
                _cancellationTokenSource.Cancel();
            }
        }
    }
}
