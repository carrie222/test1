using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _Model = new MyModel();
            this.DataContext = _Model;
        }
        private MyModel _Model;

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OnShowData_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show(_Model.Data);
        }

        private void OnShowData_CanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OnClearData_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _Model.Data = string.Empty;
        }

        private void OnClearData_CanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _Model != null && !string.IsNullOrEmpty(_Model.Data);
        }
    }
}
