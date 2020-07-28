using Autofac;
using GalaSoft.MvvmLight.Ioc;
using System.Windows;

namespace TestMoqSimpleIoc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            ServLocator.getInteger = new GetInteger();
            
            InitializeComponent();
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            IntWrapper iw = new IntWrapper();
            int a = iw.GetFromInterface();
            MessageBox.Show(a.ToString());
        }
    }
}
