namespace MonkeyFinderHybrid.MauiPages;

public partial class MonkeyRatingPage : ContentPage
{
	public MonkeyRatingPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		Debug.WriteLine($"Monkey rating: {rating.Value}");
		Navigation.PopModalAsync();
    }
}