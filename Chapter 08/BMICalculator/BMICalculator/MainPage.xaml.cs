namespace BMICalculator;

public partial class MainPage : ContentPage
{
    BMI MyBMI;

    public MainPage()
    {
        InitializeComponent();
        MyBMI = new BMI { BMIValue = 0 };
        BindingContext = MyBMI;
    }

    private void slr_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        CalculateBMI();
    }

    private void CalculateBMI()
    {
        Double height = slrHeight.Value / 100;
        Double weight = slrWeight.Value;

        MyBMI.BMIValue = weight / (height * height);
    }
}

