using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Diplomska1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Baza_Diplomska2022Entities db = new Baza_Diplomska2022Entities();
        public MainWindow()
        {
            InitializeComponent();
            var x = from a in db.Kriterij select a;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Btn_EXIT_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Izbira_Predmeta.Visibility = Visibility.Visible;
            Window2 obj2 = new Window2();
            this.Visibility = Visibility.Hidden;
            obj2.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            MainWindow obj1 = new MainWindow();
            this.Visibility = Visibility.Hidden;
            obj1.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //System.Windows.Data.CollectionViewSource kontrolne_NalogeViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("kontrolne_NalogeViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // kontrolne_NalogeViewSource.Source = [generic data source]
        }
    }
}
