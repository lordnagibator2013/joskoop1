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
    bool isDraw = false;
    bool brush = true;
    Color currentColor = Color.FromRgb(0, 0, 0);
    Point point1;
    private void Error()
    {
        MessageBox.Show("ты дурачина");
    }

    private void Brush(object sender, RoutedEventArgs e)
    {
        brush = true;
        UpdateBC();
    }

    private void Eraser(object sender, RoutedEventArgs e)
    {
        brush = false;
        UpdateBC();
    }

    private void Clear(object sender, RoutedEventArgs e)
    {

    }
    
    private void Draw(Point x1, Point x2, Color color)
    {
        SolidColorBrush brush = new SolidColorBrush(color);
        Line line = new Line
        {
            X1 = x1.X,
            Y1 = x1.Y,
            X2 = x2.X,
            Y2 = x2.Y,
            Stroke = brush,
            StrokeThickness = 3
        };
        Canvass.Children.Add(line);
    }

    private void Draw_down(object sender, MouseButtonEventArgs e)
    {
        if(!brush){ return; }
        isDraw = true;
        point1 = e.GetPosition(Canvass);
    }

    private void Draw_move(object sender, MouseEventArgs e)
    {
        if (!isDraw)
        {
            return;
        }
        Point point2 = e.GetPosition(Canvass);
        Draw(point1, point2, currentColor);
        point1 = point2;
    }

    private void Draw_up(object sender, MouseButtonEventArgs e)
    {
        isDraw = false;
    }

    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void UpdateBC()
    {
        if (brush)
        {
            BrushB.Background = Brushes.LightBlue;
            EraserB.Background = Brushes.LightGray;
        }
        else
        {
            BrushB.Background = Brushes.LightGray;
            EraserB.Background = Brushes.LightBlue;
        }
    }
}