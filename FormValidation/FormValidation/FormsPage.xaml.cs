using Xamarin.Forms;


namespace FormValidation
{
    public partial class FormsPage : ContentPage
    {
        public FormsPage()
        {
            InitializeComponent();
            ShowLoginIndicator.IsRunning = false;
        }

        private void LoginBt_Clicked(object sender, System.EventArgs e)
        {
            ShowLoginIndicator.IsVisible = true;
            ShowLoginIndicator.IsRunning = true;
        }

        private void UserNameEntry_Focused(object sender, FocusEventArgs e)
        {
            UserNameEntry.HorizontalTextAlignment = TextAlignment.Center;
        }

        private void UserNameEntry_Unfocused(object sender, FocusEventArgs e)
        {
            UserNameEntry.HorizontalTextAlignment = TextAlignment.Start;
        }

        private void PasswordEntry_Focused(object sender, FocusEventArgs e)
        {
            PasswordEntry.HorizontalTextAlignment = TextAlignment.Center;
        }

        private void PasswordEntry_Unfocused(object sender, FocusEventArgs e)
        {
            PasswordEntry.HorizontalTextAlignment = TextAlignment.Start;
        }
    }
}
