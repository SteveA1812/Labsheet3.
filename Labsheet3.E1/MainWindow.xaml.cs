using System;
using System.Windows;
using System.Collections.ObjectModel;
using System.Text;

namespace Labsheet3.E1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Expenses> expenses = new ObservableCollection<Expenses>();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Expenses e1 = new Expenses() { Type = "Office", Amount = 15.55m, ClaimedDate = new DateTime(2014, 02, 12) };
            Expenses e2 = new Expenses() { Type = "Entertainment", Amount = 82.63m, ClaimedDate = new DateTime(2014, 01, 25) };
            Expenses e3 = new Expenses() { Type = "Entertainment", Amount = 26.81m, ClaimedDate = new DateTime(2014, 02, 06) };
            expenses.Add(e1);
            expenses.Add(e2);
            expenses.Add(e3);
            lbxExpenses.ItemsSource = expenses;
            txtblkTotalExpenses.Text = "Total Expenses €" + GetTotalExpenses().ToString();

        }

        private void btnAddExpense_Click(object sender, RoutedEventArgs e)
        {
            //Create random info
            string type = RandomString(5, true);
            RandomGenerator generator = new RandomGenerator();
            int rand = generator.RandomNumber(0, 100);
            decimal amount = Convert.ToDecimal(rand);
            DateTime claimedDate = DateTime.Now;

            //create object with info
            Expenses newExpenses = new Expenses() { Type = type, ClaimedDate = claimedDate, Amount = amount };

            //add to collection
            expenses.Add(newExpenses);
            txtblkTotalExpenses.Text = "Total Expenses €" + GetTotalExpenses().ToString();
        }
        private decimal GetTotalExpenses()
        {
            decimal total = 0;

            foreach (Expenses e in expenses)
            {
                total += e.Amount;
            }

            return total;
        }

        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();

        }
    

        private class RandomGenerator
        {
            // Generate a random number between two numbers    
            public int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            expenses.RemoveAt(expenses.Count - 1);
            txtblkTotalExpenses.Text = "Total Expenses €" + GetTotalExpenses().ToString();
        }
    }
}

   
