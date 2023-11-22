namespace AppNavigationPage;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}

    private void OnButtonNextPageClicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new ThirdPage());
    }

    private void OnButtonPreviousPageClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}