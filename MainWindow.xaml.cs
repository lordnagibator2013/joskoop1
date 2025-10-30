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

namespace lord13;

public partial class MainWindow : Window
{
    int count = 0;
    string[] listbox = new string[50];

    private void NeGotovo()
    {
        MessageBox.Show("не готово(");
    }

    private void Error()
    {
        MessageBox.Show("ты дурачина");
    }

    // public MainWindow()
    // {
    //     InitializeComponent();
    // }
}