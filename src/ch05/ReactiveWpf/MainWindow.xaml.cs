using Reactive.Bindings;
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

namespace ReactiveWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        ViewModel _vm;
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _vm = new ViewModel();
            this.DataContext = _vm;
        }
    }

    public class ViewModel
    {
        public ReactiveProperty<string> Name { get; }
        public ReactiveProperty<string> Memo { get; }

        public ViewModel()
        {
            Name = new ReactiveProperty<string>();
            Memo = new ReactiveProperty<string>()
                .SetValidateNotifyError(x => string.IsNullOrEmpty(x) ? "Invalid value" : null);
        }
    }
}
