using System.Windows;
using Microsoft.Phone.Controls;

namespace LShape
{
    public partial class MainPage : PhoneApplicationPage
    {
        private bool _isSettingsOpen = false;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void SettingsButton_OnTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (_isSettingsOpen)
            {
                VisualStateManager.GoToState(this, "Closed", true);
                _isSettingsOpen = false;
            }
            else
            {
                VisualStateManager.GoToState(this, "Open", true);
                _isSettingsOpen = true;
            }

            e.Handled = true;
        }

        private void PhoneApplicationPage_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (_isSettingsOpen)
            {
                VisualStateManager.GoToState(this, "Closed", true);
                _isSettingsOpen = false;
                e.Handled = true;
            }
        }

        private void Slider_ManipulationCompleted(object sender, System.Windows.Input.ManipulationCompletedEventArgs e)
        {
            if (_isSettingsOpen)
            {
                VisualStateManager.GoToState(this, "Closed", true);
                _isSettingsOpen = false;
                e.Handled = true;
            }
        }
    }
}