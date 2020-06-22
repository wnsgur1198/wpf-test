using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace 의료IT공학과.데이터베이스
{
	partial class WPF_Test : Window
	{
		[STAThread]
		static void Main(string[] args)
		{
			new Application().Run(new WPF_Test());
		}

		//생성자 -------------------------------
		public WPF_Test()
		{
			InitializeComponent();

		}

        private void updateBtnClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("수정 버튼이 눌렸습니다.");
        }

        private void deleteBtnClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("삭제 버튼이 눌렸습니다.");
        }

        private void insertBtnClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("입력 버튼이 눌렸습니다.");
        }
    }
}