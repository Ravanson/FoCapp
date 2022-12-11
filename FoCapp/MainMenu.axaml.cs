using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FoCapp;

public partial class MainMenu : UserControl
{
    public MainMenu()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}