namespace Clicker.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        bool isAnimating;

        private async void OnBreathClicked(object sender, EventArgs e)
        {
            if (isAnimating)
                return;

            isAnimating = true;

            await BreathButton.ScaleTo(0.9, 60, Easing.CubicIn);
            await BreathButton.ScaleTo(1.1, 120, Easing.CubicOut);
            await BreathButton.ScaleTo(1.0, 80, Easing.CubicInOut);

            isAnimating = false;
        }



    }

}