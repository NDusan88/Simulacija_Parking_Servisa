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

namespace WpfSimulacijaParkingServisa
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
        private int kapacitet = 10;
        private int slobodno;
        private Automobil auto;

        private void upis()
        {
            textBoxPrikaz.AppendText(auto.ToString());
            textBoxPrikaz.AppendText("\n\r\n\rUkupno automobila: " + Automobil.VratiBrojac().ToString());
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBoxMesta.Text = kapacitet.ToString();
            slobodno = kapacitet;
        }

        private void buttonUlaz_Click(object sender, RoutedEventArgs e)
        {
            if (slobodno > 0)
            {
                auto = new Automobil();
                auto.Upisi(textBoxIme.Text, textBoxRegistracija.Text);
                slobodno = kapacitet - Automobil.VratiBrojac();
                textBoxMesta.Text = slobodno.ToString();

                textBoxPrikaz.Clear();
                textBoxPrikaz.Text = "Ulaz\n\r";
                upis();
            }
            else
            {
                MessageBox.Show("Parking je pun");

                textBoxRegistracija.Text = "";
                textBoxIme.Text = "";
                textBoxRegistracija.Focus();
            }
        }

        private void buttonIzlaz_Click(object sender, RoutedEventArgs e)
        {
            if (slobodno < kapacitet)
            {
                auto = new Automobil(textBoxRegistracija.Text, textBoxIme.Text);

                slobodno++;
                textBoxMesta.Text = slobodno.ToString();

                textBoxPrikaz.Clear();
                textBoxPrikaz.Text = "Izlaz\n\r";
                upis();
            }
            else
            {
                MessageBox.Show("Parking je prazan");
            }
        }
    }
}

