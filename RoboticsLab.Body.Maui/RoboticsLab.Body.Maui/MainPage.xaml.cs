namespace RoboticsLab.Body.Maui
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public partial class MainPage : ContentPage
    {
        int count = 0;
        int bowCount = 0;

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
            // Call the Python Backend Flask API
            Task.Run(async () =>
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync("http://localhost:5000/api/torso/bow");
                    var content = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        var green = new Color(0, 255, 0);
                        BowBtn.BackgroundColor = green;
                    }
                    BowBtn.Text = "Crap";
                    if (content == "Bowing")
                        BowBtn.Text = $"Bowed {++bowCount} times";
                    else
                        Console.WriteLine("Not Bowing");
                }
            });

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
