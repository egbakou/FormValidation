using Xamarin.Forms;

namespace FormValidation.Controls
{
    public partial class DashBoardButton : ContentView
	{
		public DashBoardButton ()
		{
			InitializeComponent ();
		}

        public ImageSource Icon
        {
            get { return DashBoardIcon.Source; }
            set { DashBoardIcon.Source = value; }
        }

        public string Label
        {
            get { return DashBoardLabel.Text; }
            set { DashBoardLabel.Text = value; }
        }
	}
}