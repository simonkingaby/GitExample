namespace RoboticsLab.Body.Maui
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnBowClicked(object sender, EventArgs e)
        {
            // Call a function in the Python module RoboticsLab.Body.Backend
            // to make the robot bow
            

            SemanticScreenReader.Announce(BowBtn.Text);
        }

        private void OnWiggleFingersClicked(object sender, EventArgs e)
        {
            SemanticScreenReader.Announce(WiggleFingersBtn.Text);
        }

        private void OnHighKickClicked(object sender, EventArgs e)
        {
            SemanticScreenReader.Announce(HighKickBtn.Text);
        }

    }

}
