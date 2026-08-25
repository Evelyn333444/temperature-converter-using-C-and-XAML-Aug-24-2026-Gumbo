using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace FirstProjectAvalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    public void clickMeHandlerIncrement(object sender, RoutedEventArgs e)
    {
        message.Text =
            message.Text == "Increment"
                ? "Increment"
                : "Increment";
    }
    public void clickMeHandlerDecrement(object sender, RoutedEventArgs e)
    {
        message.Text =
            message.Text == "Decrement"
                ? "Decrement"
                : "Decrement";
    }
    public void clickMeHandlerReset(object sender, RoutedEventArgs e)
    {
        message.Text =
            message.Text == "Reset"
                ? "Reset"
                : "Reset";
    }
    //Now we have clickMeHandlers for the Increment, Reset, and Decrement buttons, although I still haven't designed what the buttons will do.
    private void TbTemperature_TextChanged(object? sender, TextChangedEventArgs e)
    {
    if (!double.TryParse(tb_temperature.Text, out double fahrenheit))
    {
        counterDisplay.Text = "Temp";  // or "?" if input isn't a number yet
        return;
    }
    double celsius = (fahrenheit - 32.0) * 5.0 / 9.0;
    counterDisplay.Text = celsius.ToString("F1");
    }
    //Lines 35-44 show the calculation of the conversion taking place when the user types in a temp in F.
}