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

namespace calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btn_szamol_Click(object sender, RoutedEventArgs e)
        { 
            int answer = 0;
            string numbers = tb_szamok.Text;
            string[] parts = numbers.Split(' ');
            int first = int.Parse(parts[0]);
            int secound = int.Parse(parts[2]);
            string op = parts[1];
            if (op == "+")
            {
                answer = first + secound;
                lb_ans.Content = answer;
            }
            else if (op == "-")
            {
                answer = first - secound;
                lb_ans.Content = answer;
            }
            else if (op == "*")
            {
                answer = first * secound;
                lb_ans.Content = answer;
            }
            else if (op == "/")
            {
                if (first == 0 || secound == 0)
                {
                    lb_ans.Content = "syntax error";
                }
                else
                {
                    answer = first / secound;
                    lb_ans.Content = answer;
                }
                
            }
            else
            {
                lb_ans.Content = "syntax error";
            }
        }
    }
}