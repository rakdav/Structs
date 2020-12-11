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

namespace Structs
{
    /// <summary>
    /// Логика взаимодействия для WindowPerson.xaml
    /// </summary>
    public partial class WindowPerson : Window
    {
        public WindowPerson(Person p)
        {
            InitializeComponent();
            FIO.Text = p.fio;
            DateBirth.SelectedDate= p.dat;
            Rost.Text = p.rost.ToString();
            Weight.Text = p.ves.ToString();
            if (p.pol == 'М') man.IsChecked = true;
            else woman.IsChecked = true;
            if (p.ekat == true) Ekat.IsChecked = true;
        }
        public WindowPerson()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        public string getFio()
        {
            return FIO.Text;
        }

        public DateTime? getBirth()
        {
            return DateBirth.SelectedDate;
        }

        public double getRost()
        {
            return double.Parse(Rost.Text);
        }

        public double getWeight()
        {
            return double.Parse(Weight.Text);
        }
        public char getPol()
        {
            if (man.IsChecked == true) return 'М';
            return 'Ж';
        }

        public bool getEkat()
        {
            if(Ekat.IsChecked==true) return true;
            return false;
        }
    }
}
