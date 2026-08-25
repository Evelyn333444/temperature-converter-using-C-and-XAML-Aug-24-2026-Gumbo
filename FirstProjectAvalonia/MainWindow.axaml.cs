using Avalonia.Controls;
using Avalonia.Interactivity;

namespace FirstProjectAvalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    public void clickMeHandlerIncrement(object sender, RoutedEventArgs e)
    {
        if (!double.TryParse(tb_temperature.Text, out double fahrenheit))
        {
            fahrenheit = 32;
        }

        tb_temperature.Text = (fahrenheit + 1).ToString("F1");
    }

    public void clickMeHandlerDecrement(object sender, RoutedEventArgs e)
    {
        if (!double.TryParse(tb_temperature.Text, out double fahrenheit))
        {
            fahrenheit = 32;
        }

        tb_temperature.Text = (fahrenheit - 1).ToString("F1");
    }

    public void clickMeHandlerReset(object sender, RoutedEventArgs e)
    {
        tb_temperature.Text = "32";
    }
    //Now we have clickMeHandlers for the Increment, Reset, and Decrement buttons, although I still haven't designed what the buttons will do.
    private void TbTemperature_TextChanged(object? sender, TextChangedEventArgs e)
    {
        if (!double.TryParse(tb_temperature.Text, out double fahrenheit))
        {
            counterDisplay.Text = "Temp";
            return;
        }

        double celsius = (fahrenheit - 32.0) * 5.0 / 9.0;
        counterDisplay.Text = celsius.ToString("F1");
    }
    //Lines 51-61 show the calculation of the conversion taking place when the user types in a temp in F.
}