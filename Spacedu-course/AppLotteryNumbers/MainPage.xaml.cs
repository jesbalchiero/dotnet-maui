namespace AppLotteryNumbers;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnGenerateLuckNumbers(object sender, EventArgs e)
	{
		TitleApp.IsVisible = false;
        ContainerLuckNumbers.IsVisible = true;

		var setNumbers = GenerateLuckNumbers();

		LuckNumber1.Text = setNumbers.ElementAt(0).ToString("D2");
		LuckNumber2.Text = setNumbers.ElementAt(1).ToString("D2");
		LuckNumber3.Text = setNumbers.ElementAt(2).ToString("D2");
		LuckNumber4.Text = setNumbers.ElementAt(3).ToString("D2");
		LuckNumber5.Text = setNumbers.ElementAt(4).ToString("D2");
		LuckNumber6.Text = setNumbers.ElementAt(5).ToString("D2");

        BtnGenerateNumbers.Text = "Generate new luck numbers";
        BtnGenerateNumbers.TextColor = Color.FromHex("#00AB37");
        BtnGenerateNumbers.BackgroundColor = Color.FromHex("#FFFFFF");
    }

	private SortedSet<int> GenerateLuckNumbers()
	{
		var setNumbers = new SortedSet<int>();

		while(setNumbers.Count < 6) { 
			var random = new Random();
			var luckNumber = random.Next(1, 60);

            setNumbers.Add(luckNumber);
		}

		return setNumbers;
	}
}