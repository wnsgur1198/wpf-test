using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace 의료IT공학과.데이터베이스
{
    class WPF_Test_Code : Window
    {
        [STAThread]
        static void Main(string[] args)
        {
            new Application().Run(new WPF_Test_Code());
        }

        //생성자 ------------------------
        public WPF_Test_Code()
        {
            Title = "WPF 테스트 코드";
            Width = 500;
            Height = 250;
            Background = Brushes.Red;

            //.....................
            Button btn = new Button();
            btn.Content = "Hello";
            btn.Margin = new Thickness(10);
            btn.FontSize = 48;

            Content = btn;
        }
    }
}