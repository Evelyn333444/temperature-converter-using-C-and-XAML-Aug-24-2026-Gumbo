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
    
}