namespace BorderVsFrame
{
	public partial class MainPage : ContentPage
	{

		public MainPage()
		{
			InitializeComponent();

			TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
			tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;

			MyFrame.GestureRecognizers.Add(tapGestureRecognizer);
			MyBorder.GestureRecognizers.Add(tapGestureRecognizer);

		}

		private async void TapGestureRecognizer_Tapped(object? sender, TappedEventArgs e)
		{
			await DisplayAlert("Alert", "Control tapped!", "OK");
		}
	}

}
