using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BevasarloListaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public class Termekek
    {

        public string TermekNev { get; set; }
        public int Mennyiseg { get; set; }
        public int Ar { get; set; }
        public string Tipus { get; set; }
        public int Osszes { get; set; }

        public Termekek(string termekNev, int mennyiseg, int ar, string tipus)
        {
            TermekNev = termekNev;
            Mennyiseg = mennyiseg;
            Ar = ar;
            Tipus = tipus;
            Osszes = Mennyiseg * Ar;
        }
    }
    public partial class MainWindow : Window
    {
        List<Termekek> termekek = new List<Termekek>();

        
        public MainWindow()
        {
            InitializeComponent();
            termekek.Add(new Termekek("Tej", 5, 450, "A"));
            termekek.Add(new Termekek("Kenyer", 10, 350, "B"));
            termekek.Add(new Termekek("Sajt", 2, 1200, "A"));
            termekek.Add(new Termekek("Alma", 20, 200, "C"));
            termekek.Add(new Termekek("Narancs", 15, 300, "C"));
            termekek.Add(new Termekek("Hús", 3, 2500, "D"));
            termekek.Add(new Termekek("Csokoládé", 7, 900, "B"));
            termekek.Add(new Termekek("Kenyér", 1, 450, "B"));
            termekek.Add(new Termekek("Tej", 12, 400, "A"));
            termekek.Add(new Termekek("Sajt", 5, 1500, "D"));
            dataGrid.ItemsSource = termekek;
        }

        private void Hozzaadas(object sender, RoutedEventArgs e)
        {
            var ujtermek = new Hozzaadas();
            if (ujtermek.ShowDialog() == true)
            {
                termekek.Add(ujtermek.ujtermek);
                dataGrid.ItemsSource = termekek;
                dataGrid.Items.Refresh();
            }
        }
    }
}