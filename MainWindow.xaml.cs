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
            
        }
        int CenterOX;
        int CenterOY ;
        int diametr;
        int CenterTX;
        int CenterTY;
        int a;
        int b;
        int c;
        public void startProgramm(int CenterOX, int CenterOY,int diametr, int CenterTX, int CenterTY, int a, int b, int c)
        {
            Circle circle1 = new Circle(CenterOX, CenterOY, diametr);
            circle1.Draw(canvasPanel);

            Triangle triangle1 = new Triangle(CenterTX, CenterTY, a, b,c);
            triangle1.Draw(canvasPanel);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int CenterOX = int.Parse(textbox1.Text);
            int CenterOY = int.Parse(textbox2.Text);
            int diametr = int.Parse(textbox3.Text);
            int CenterTX = int.Parse(textbox4.Text);
            int CenterTY = int.Parse(textbox5.Text);
            int a = int.Parse(textbox6.Text);
            int b = int.Parse(textbox7.Text);
            int c = int.Parse(textbox8.Text);
            startProgramm(CenterOX, CenterOY, diametr, CenterTX, CenterTY, a, b, c);
        }
    }
}
