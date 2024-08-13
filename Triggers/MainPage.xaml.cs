namespace Triggers
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public int Count 
        { 
            get => count;
            set
            {
                count = value;
                OnPropertyChanged(nameof(Count));
            }
        }

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Count++;

            if (Count == 1)
            {
                CounterBtn.Text = $"Clicked {Count} time";

                MultiTriggerButton.Text = $"Clicked {Count} time";
            }
            else
            {
                CounterBtn.Text = $"Clicked {Count} times";

                MultiTriggerButton.Text = $"Clicked {Count} times";
            }
                
            SemanticScreenReader.Announce(CounterBtn.Text);

            SemanticScreenReader.Announce(MultiTriggerButton.Text);
        }
    }

}
