using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace SeaBattel_Winter.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContextField.xaml
    /// </summary>
    public partial class ContextField : UserControl
    {
        private CellState _state;
        private bool flag;
        private int _x;
        private int _y;
        public ContextField(int X,int Y)
        {
            InitializeComponent();
            _x = X;
            _y = Y;
        }

        private void CellContext_MouseEnter(object sender, MouseEventArgs e)
        {
            CellContext.Background =GetImage();
            _state = CellState.Miss;
        }

        private void CellContext_MouseLeave(object sender, MouseEventArgs e)
        {
            SeaField.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + @"/img/Sea.jpg", UriKind.Relative));
            CellContext.Background = SeaField;
        }
        private Brush GetImage()
        {
            switch (_state)
            {
                case CellState.Damage:
                    SeaField.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + @"/img/explosion.png", UriKind.Relative));
                    CellContext.Background = SeaField;
                    return CellContext.Background;
                case CellState.Miss:
                    SeaField.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + @"/img/explosion1.jpg", UriKind.Relative));
                    CellContext.Background = SeaField;
                    return CellContext.Background;
                case CellState.None:
                    SeaField.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + @"/img/cloud.jpg", UriKind.Relative));
                    CellContext.Background = SeaField;
                    return CellContext.Background;
                case CellState.Ship:
                    SeaField.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + @"/img/Sea.jpg", UriKind.Relative));
                    CellContext.Background = SeaField;
                    return CellContext.Background;
                default:
                    SeaField.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + @"/img/Sea.jpg", UriKind.Relative));
                    CellContext.Background = SeaField;
                    return CellContext.Background;
            }

            }
        public enum CellState
        {
            None=0,
            Ship=1,
            Damage=2,
            Miss=3,
        }

        private void CellContext_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
