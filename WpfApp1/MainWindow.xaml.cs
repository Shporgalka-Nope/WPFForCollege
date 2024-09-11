using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBlock toSend;
        TextBox[] textBoxes;
        public MainWindow()
        {
            InitializeComponent();
            toSend = Result;
            textBoxes = new TextBox[] { tb_Log, tb_Pass, tb_Name, tb_LName, tb_Bd };
        }
        private void result_onCkick(object sender, RoutedEventArgs e)
        {
            string str = "";
            foreach(TextBox tb in textBoxes) 
            {
                str += tb.Text + "\n";
            }
            Result.Text = str;
        }
    }
}