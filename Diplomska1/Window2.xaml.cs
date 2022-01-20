using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;


namespace Diplomska1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        System.Windows.Data.CollectionViewSource predmetiViewSource = new CollectionViewSource();
        System.Windows.Data.CollectionViewSource letnikViewSource = new CollectionViewSource();
        System.Windows.Data.CollectionViewSource poglavjeViewSource = new CollectionViewSource();
        System.Windows.Data.CollectionViewSource tezavnostViewSource = new CollectionViewSource();

        Baza_Diplomska2022Entities db = new Baza_Diplomska2022Entities();
        public Window2()
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

            var mat = from a in db.Predmeti
                          //where a.ID_Predmeta == 2
                      select a;


            db.Predmeti.Load();

            predmetiViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["predmetiViewSource"];
            predmetiViewSource.Source = db.Predmeti.Local;

            //***********************************************************************

            var let = from b in db.Letnik
                          //where predmetiViewSource.Source == db.Predmeti.Local
                      select b;

            db.Letnik.Load();

            letnikViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["letnikViewSource"];
            letnikViewSource.Source = db.Letnik.Local;

            //***********************************************************************

            var pog = from c in db.Poglavje
                          //where c.ID_Poglavja == 1
                      select c;


            db.Poglavje.Load();

            poglavjeViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["poglavjeViewSource"];
            poglavjeViewSource.Source = db.Poglavje.Local;


            //***********************************************************************

            var tez = from d in db.Stopnja_Težavnosti
                      select d;

            db.Stopnja_Težavnosti.Load();

            tezavnostViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["tezavnostViewSource"];
            tezavnostViewSource.Source = db.Stopnja_Težavnosti.Local;

            //***********************************************************************


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 obj3 = new Window3();
            this.Visibility = Visibility.Hidden;
            obj3.Show();
        }


    }
}
