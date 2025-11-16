using Microsoft.Maui.Graphics; // Make sure this 'using' is at the top

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        // This variable is for your heart button
        private bool isHeartButtonClicked = false;

        public MainPage()
        {
            InitializeComponent();
        }

        // This is the ONLY button-click method that should be in this file
        private void HeartButton_Clicked(object sender, EventArgs e)
        {
            isHeartButtonClicked = !isHeartButtonClicked; // Toggles true/false

            if (isHeartButtonClicked)
            {
                // Set to Red
                HeartButton.BackgroundColor = Colors.Red;
            }
            else
            {
                // Set back to Gray
                HeartButton.BackgroundColor = Colors.LightGray;
            }
        }
    }
}