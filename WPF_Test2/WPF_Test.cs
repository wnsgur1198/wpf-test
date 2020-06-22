using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace WPF_Test
{
    partial class WPF_Test : Window
    {
        Image ximg = null;

        [STAThread]
        static void Main()
        {
            new Application().Run(new WPF_Test());
        }

        public WPF_Test()
        {
            InitializeComponent();



            myList.SelectionChanged += new SelectionChangedEventHandler(myList_SelectionChanged);
            
            myList.Items.Add(new ListItem("001","홍길동","서울","010-1234-5678", "Green"));
            myList.Items.Add(new ListItem("002", "박길동", "대전", "010-5678-1234", "Orange"));
            myList.Items.Add(new ListItem("003", "고길동", "강릉", "010-1111-2222", "Blue"));

            BookList.Items.Add(new BookItem("1234-5678", "Androids Build your Own LifeLike Robots"));
            BookList.Items.Add(new BookItem("2134-8765", "Mathmatical Statistics"));

            StackPanel imageStack = new StackPanel();
            imageStack.Orientation = Orientation.Horizontal;

            mainStack.Children.Add(imageStack);

            Image img;
            
            //img.Source = new BitmapImage(new Uri("pack://application:,,,/xImages/google_Logo3.png"));
            //img.Source = new BitmapImage(new Uri("C:/Users/Owner/Desktop/pjkim/WPF_Test/MyImages/google_Logo.png"));
            //img.Source = new BitmapImage(new Uri("../../../MyImages/google_Logo.png", UriKind.Relative));

            img = new Image();
            img.Source = new BitmapImage(new Uri("xImages/google_Logo3.png", UriKind.Relative));
            img.Width = 200;
            imageStack.Children.Add(img);

            img = new Image();
            img.Source = new BitmapImage(new Uri("xImages/clear.png", UriKind.Relative));
            img.Stretch = Stretch.None;
            imageStack.Children.Add(img);

            img = new Image();
            img.Source = new BitmapImage(new Uri("xImages/apple.png", UriKind.Relative));
            img.Width = 150;
            imageStack.Children.Add(img);

            img = new Image();
            img.Source = new BitmapImage(new Uri("xImages/clown.png", UriKind.Relative));
            img.Width = 150;
            img.Stretch = Stretch.Uniform;
            imageStack.Children.Add(img);

            ximg = new Image();
            ximg.Source = new BitmapImage(new Uri("xImages/heart01.png", UriKind.Relative));
            ximg.Width = 150;
            ximg.Stretch = Stretch.Uniform;
            imageStack.Children.Add(ximg);

            img = new Image();
            img.Source = new BitmapImage(new Uri("xImages/bug01.png", UriKind.Relative));
            img.Width = 150;
            img.Stretch = Stretch.Uniform;
            imageStack.Children.Add(img);

            img = new Image();
            img.Source = new BitmapImage(new Uri("xImages/X-file.png", UriKind.Relative));
            img.Width = 150;
            img.Stretch = Stretch.Uniform;
            imageStack.Children.Add(img);

            ColorBtn.Click += new RoutedEventHandler(ColorBtn_Click);
    
        }

        void ColorBtn_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation();
            a.From = 150;
            a.By = 50;
            a.Duration = new Duration(TimeSpan.Parse("0:0:0.2"));
            a.AutoReverse = true;
            a.RepeatBehavior = new RepeatBehavior(1);
            //a.EasingFunction = new QuadraticEase();
            a.AccelerationRatio = 1.0;

            ximg.BeginAnimation(Image.WidthProperty, a);
            ximg.BeginAnimation(Image.HeightProperty, a);
        }



        void myList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView list = sender as ListView;
            ListItem item = list.SelectedItem as ListItem;

            if (item == null) return;

            if (item.itemColor.Equals("Red")) item.itemColor = "Green";
            else item.itemColor = "Red";

            list.Items.Refresh();
        }


        void BookItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            BookItem item = ((ListViewItem)sender).Content as BookItem;

            Console.WriteLine(item.bookname);

        }

        void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {

            ListItem item = ((ListViewItem)sender).Content as ListItem;

            Console.WriteLine(item.addr);

        }
    }

    class BookItem
    {
        public BookItem(string isbn, string bookname)
        {
            this.isbn = isbn;
            this.bookname = bookname;
            
        }

        public string isbn { get; set; }
        public string bookname { get; set; }
        
    }

    class ListItem
    {
        public ListItem(string id, string name, string addr, string mail, string itemColor)
        {
            this.id = id;
            this.name = name;
            this.addr = addr;
            this.mail = mail;
            this.itemColor = itemColor;
        }

        public string id { get; set; }
        public string name { get; set; }
        public string addr { get; set; }
        public string mail { get; set; }
        public string itemColor { get; set; }
    }

}//ns