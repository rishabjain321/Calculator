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

namespace calculatorWithDatabinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private backend _myModel;
        public MainWindow()
        {
            InitializeComponent();
            _myModel = new backend();
            this.DataContext = _myModel;
        }

        private void buttons_Click(object sender, RoutedEventArgs e)
        {
            if ("System.Windows.Controls.Button: +" == sender.ToString())
            {
                _myModel.opperation = "+";
            }
            else if ("System.Windows.Controls.Button: -" == sender.ToString())
            {
                _myModel.opperation = "-";
            }
            else if ("System.Windows.Controls.Button: /" == sender.ToString())
            {
                _myModel.opperation = "/";
            }
            else if ("System.Windows.Controls.Button: X" == sender.ToString())
            {
                _myModel.opperation = "*";
            }
            else if ("System.Windows.Controls.Button: =" == sender.ToString())
            {
                _myModel.calculate();
            }
        }
    }
}
