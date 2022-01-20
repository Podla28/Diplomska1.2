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
using System.Windows.Shapes;
using System.Data.Entity;

namespace Diplomska1
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        System.Windows.Data.CollectionViewSource LetnikViewSource = new CollectionViewSource();

        Baza_Diplomska2022Entities db1 = new Baza_Diplomska2022Entities();
        public Window3()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            MainWindow obj1 = new MainWindow();
            this.Visibility = Visibility.Hidden;
            obj1.Show();
        }

        private void Btn_EXIT_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var let = from a in db1.Letnik
                          //where a.ID_Predmeta == 1
                      select a;

            db1.Letnik.Load();


           
            LetnikViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["LetnikViewSource"];
            LetnikViewSource.Source = db1.Letnik.Local;
            //predmetiViewSource.Source1 = db.Predmeti.Local;
        }
    }
}
