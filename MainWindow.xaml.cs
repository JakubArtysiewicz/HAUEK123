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

namespace HAUEK123
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void podsumuj_button_Click(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            var item = (ComboBoxItem)wybraneAutoBox.SelectedItem;
            var liczbaDniInt = int.Parse(liczbaDni.Text);
            window.wybraneAuto.Text = $"Wybrane auto: {item.Content} Czas Wynajmu:{liczbaDniInt}";
            window.doZaplaty.Text = $"Do zapłaty: {liczbaDniInt * 10} zł";
            window.Show();
        }
    }
}