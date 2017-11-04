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

namespace SeaBattel_Winter.Controls
{
    /// <summary>
    /// Логика взаимодействия для FieldForGame.xaml
    /// </summary>
    public partial class FieldForGame :Grid
    {
        private int _size = 10;
        public FieldForGame()
        {
            InitializeComponent();
            BuildEnd();
            BuildField();
        }
        public void BuildField()
        {
            for (int i = 0; i < _size; i++)
            {
                var lab = new Label
                {
                    Content =(char) ('A' + i ),
                    Width=24,
                    HorizontalAlignment=HorizontalAlignment.Center,
                    VerticalAlignment=VerticalAlignment.Center,
                };
                var lab1 = new Label
                {
                    Content = i + 1,
                    Width = 24,
                    HorizontalAlignment=HorizontalAlignment.Center,
                    VerticalAlignment=VerticalAlignment.Center,
                };
                for (int j = 0; j <= _size; j++)
                {
                    var cell = new ContextField(i+1,j+1)
                    {
                        Height = 24,
                        Width = 24,
                        Margin = new Thickness(1)
                    };
                    Grid.SetRow(cell, i+1);
                    Grid.SetColumn(cell, j+1);
                    Children.Add(cell);
                }
                Grid.SetRow(lab, 0);
                Grid.SetColumn(lab, i + 1);
                Grid.SetRow(lab1, i + 1);
                Grid.SetColumn(lab1, 0);
                Children.Add(lab);
                Children.Add(lab1);
            }
        }
        public void BuildEnd()
        {
            for (int i = 0; i < _size+1; i++)
            {
                var rowDef = new RowDefinition()
                {
                    Height = GridLength.Auto
                };
                var colDef = new ColumnDefinition()
                {
                    Width = GridLength.Auto
                };
                RowDefinitions.Add(rowDef);
                ColumnDefinitions.Add(colDef);
            }
        }
    }
}
