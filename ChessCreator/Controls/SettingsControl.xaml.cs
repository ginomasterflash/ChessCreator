using ChessCreator.Core;
using System.Windows.Controls;


namespace ChessCreator
{
    /// <summary>
    /// Logica di interazione per SettingsControl.xaml
    /// </summary>
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();

            // Set data context to settings view model
            DataContext = IoC.Settings;
        }
    }
}
