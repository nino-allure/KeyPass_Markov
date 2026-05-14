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

namespace AppKeyPass_Markov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public static MainWindow init;
        public static string Token;
        public MainWindow()
        {
            InitializeComponent();
            init = this;
            OpenPages(new Pages.Login());
        }
        public void OpenPages(Page OpenPage) {
            frame.Navigate(OpenPage);
        }
    }
}