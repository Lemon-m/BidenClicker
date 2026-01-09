namespace Clicker.Pages
{
    public partial class MainPage : ContentPage
    {
        bool isAnimating;
        bool powerup1OnCooldown;
        bool powerup2OnCooldown;
        bool powerup3OnCooldown;
        bool powerup4OnCooldown;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnBreathClicked(object sender, EventArgs e)
        {
            if (isAnimating) return;

            isAnimating = true;

            await BreathButton.ScaleTo(0.9, 60);
            await BreathButton.ScaleTo(1.1, 120);
            await BreathButton.ScaleTo(1.0, 80);

            isAnimating = false;
        }

        private async void OnPowerup1Clicked(object sender, EventArgs e)
        {
            if (powerup1OnCooldown) return;
            powerup1OnCooldown = true;

            await StartPowerupCooldown(
                Powerup1Button,
                Powerup1Cooldown,
                Powerup1CooldownText,
                15
            );

            powerup1OnCooldown = false;
        }

        private async void OnPowerup2Clicked(object sender, EventArgs e)
        {
            if (powerup2OnCooldown) return;
            powerup2OnCooldown = true;

            await StartPowerupCooldown(
                Powerup2Button,
                Powerup2Cooldown,
                Powerup2CooldownText,
                15
            );

            powerup1OnCooldown = false;
        }

        private async void OnPowerup3Clicked(object sender, EventArgs e)
        {
            if (powerup3OnCooldown) return;
            powerup3OnCooldown = true;

            await StartPowerupCooldown(
                Powerup3Button,
                Powerup3Cooldown,
                Powerup3CooldownText,
                15
            );

            powerup1OnCooldown = false;
        }

        private async void OnPowerup4Clicked(object sender, EventArgs e)
        {
            if (powerup4OnCooldown) return;
            powerup4OnCooldown = true;

            await StartPowerupCooldown(
                Powerup4Button,
                Powerup4Cooldown,
                Powerup4CooldownText,
                15
            );

            powerup1OnCooldown = false;
        }

        private async Task StartPowerupCooldown(
            ImageButton button,
            Grid overlay,
            Label label,
            int seconds)
        {
            button.IsEnabled = false;
            overlay.IsVisible = true;

            for (int i = seconds; i > 0; i--)
            {
                label.Text = i.ToString();
                await Task.Delay(1000);
            }

            overlay.IsVisible = false;
            button.IsEnabled = true;
        }
    }
}
