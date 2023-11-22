namespace AppNavigationPage;

public partial class ThirdPage : ContentPage
{
	public ThirdPage()
	{
		InitializeComponent();
	}

    private void OnButtonPreviousPageClicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}