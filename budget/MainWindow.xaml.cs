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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace budget
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Note> notes = new List<Note>();
        private List<string> types = new List<string>();
        private int mon;
        int index;
        int sum = 0;

        public MainWindow()
        {
            InitializeComponent();
            Picker.Text = DateTime.Today.ToString();
            notes = Coverter.Deser<List<Note>>("file.json");
            Table.ItemsSource = notes;
            TotalSum();
        }

        private void addtiper(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            bool? result = window1.ShowDialog();

            if (result == true) 
            {
                string newT = window1.InType;
                TypeNote.Items.Add(newT);
                TypeNote.SelectedItem = newT;
            }
        }

        private void Creater()
        {
            mon = Convert.ToInt32(SumMoney.Text);
            Note note = new Note(Convert.ToDateTime(Picker.SelectedDate), NameNote.Text, (string)TypeNote.SelectedItem, mon, true);
            notes.Add(note);
            Table.ItemsSource = null;
            Table.ItemsSource = notes;
        }

        private void addcic(object sender, RoutedEventArgs e)
        {
            Creater();
            TotalSum();
        }

        private void deleter()
        {
            notes[index] = (Note)Table.SelectedItem;
            notes.RemoveAt(index);
            Table.ItemsSource = null;
            Table.ItemsSource = notes;
            TotalSum();
        }

        private void delcic(object sender, RoutedEventArgs e)
        {
            deleter();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Coverter.Ser(notes,"file.json");
        }

        private void TotalSum()
        {
            int sum = 0;
            foreach ( var Note in notes )
            {
                if (Note.IsComExp == true)
                {
                    sum += Note.Balance;
                }
                else
                {
                    sum -= Note.Balance;
                }
            }
            Itog.Content = sum;
        }

        private void Table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NameNote.Text = notes[Table.SelectedIndex].Name;
            TypeNote.SelectedItem = notes[Table.SelectedIndex].Type;
            SumMoney.Text = notes[Table.SelectedIndex].Balance.ToString(); 
        }
    }
}
