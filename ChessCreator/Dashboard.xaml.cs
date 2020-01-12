
using System.Windows;

namespace ChessCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();

            DataContext = new WindowViewModel(this);
        }
    }
}
