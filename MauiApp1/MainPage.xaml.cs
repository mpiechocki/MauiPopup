using CommunityToolkit.Maui.Views;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		var popup = new NewPopup();
		Shell.Current.ShowPopup(popup);
	}
}

