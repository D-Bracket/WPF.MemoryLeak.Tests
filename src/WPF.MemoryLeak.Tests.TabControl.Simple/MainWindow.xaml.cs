using System.Windows;
using System.Windows.Controls;

namespace WPF.MemoryLeak.Tests.TabControl.Simple
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static int _headerIndex = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            LeakyTabControl.Items.Add(new TabItem() { Content = new TestView(), Header = $"TabItem_{_headerIndex}" });
            _headerIndex++;
        }

        private void ButtonRemove_Click(object sender, RoutedEventArgs e)
        {
            if (LeakyTabControl.Items.Count > 0)
                LeakyTabControl.Items.RemoveAt(0);
        }
    }
}