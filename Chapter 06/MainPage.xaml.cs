namespace ColorPicker;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        this.Loaded += MainPage_Loaded;
	}

    private void MainPage_Loaded(object sender, EventArgs e)
    {
        Color color = Color.FromRgb(0,0,0);
        SetBackgroundColor(color);
    }

    private void slrValue_ValueChanged(object sender, ValueChangedEventArgs e)
	{
        var red = rValue.Value;
        var green = gValue.Value;
        var blue = bValue.Value;

        Color color = Color.FromRgb(red, green, blue);

        SetBackgroundColor(color);
    }

	private void Button_Clicked(object sender, EventArgs e)
	{
        var random = new Random();

        var color = Color.FromRgb(
        random.Next(0, 255),
        random.Next(0, 255),
        random.Next(0, 255));

        SetBackgroundColor(color);
    }

    private void SetBackgroundColor(Color color)
    {
        lblInfo.Text = "";
        AppBackground.BackgroundColor = color;
        rgbValue.Text = color.ToHex();
    }

    private async void copyBtn_Clicked(object sender, EventArgs e)
    {
        await Clipboard.SetTextAsync(rgbValue.Text);
        lblInfo.Text = "Copied to clipboard";
    }
}

