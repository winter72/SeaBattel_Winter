using SeaBattel_Winter.Controls;
using ServiceSeaBattle.Configuration;
using ServiceSeaBattle.UnitOfWork;
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

namespace SeaBattel_Winter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EnterAccount enter;
        public MainWindow()
        {
            InitializeComponent();
            AutoMapperConfiguration.Configure();
            enter = new EnterAccount();
            enter.Show();
            enter.Topmost = true;
        }
    }
}
