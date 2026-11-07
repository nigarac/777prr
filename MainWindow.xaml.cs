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
using _7ПрСизов.Classes;

namespace _7ПрСизов
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            startProgramm();
        }

        public void startProgramm()
        {
            Circle circle1 = new Circle(51, 51, 155);
            circle1.Draw(canvasPanel);

            Triangle triangle1 = new Triangle(80, 80, 2,3,713);
            triangle1.Draw(canvasPanel);
        }


        
    }
}
