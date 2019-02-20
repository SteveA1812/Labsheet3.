using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Member> members = new ObservableCollection<Member>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //string[] names = { "Tom", "Dick", "Harry" };

            Member m1 = new Member() { Name = "Tom Jones", DateJoined = new DateTime(2015,01,23), Type = "Full" };
            Member m2 = new Member() { Name = "Mary Smith", DateJoined = new DateTime(2013,06,01), Type = "Student" };
           

            members.Add(m1);
            members.Add(m2);
           

            lbxMembers.ItemsSource = members;
            txtbkNumMem.Text ="Total Members "+ GetTotalMembers().ToString();
        }

        private decimal GetTotalMembers()
        {
           
              int  total = members.Count;
            

            return total;
        }

        private void AddMember_Click(object sender, RoutedEventArgs e)
        {
            string name = NameInput.Text;
            string type = MemType.Text;
            DateTime datejoined = DateSelect.SelectedDate.Value;
            Member newMember = new Member() { Name = name, DateJoined = datejoined, Type = type };
            members.Add(newMember);
            txtbkNumMem.Text = "Total Members " + GetTotalMembers().ToString();

        }

        private void lbxMembers_OnClick(object sender, RoutedEventArgs e)

        {

            NameInput.Text = lbxMembers.SelectedItem.ToString();
        }
    }
}
