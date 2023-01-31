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

namespace prog122notes7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        Student selectedStudent = null;
        public MainWindow()
        {
            InitializeComponent();

            // how to add items to a selection box
            //Add to a selection by ACCESSING its items list
            //lbDisplay.Items.Add("Jonathan");
            //lbDisplay.Items.Add(1);
            //lbDisplay.Items.Add(1.6);
            //lbDisplay.Items.Add(true);
            Preload();
            DisplayToListBox();
            DisplayToComboBox();
            //cbDisplay.Items.Add("Nico Robin");
            // Automaticlly selcet the first item in out listbox on load
            lbDisplay.SelectedIndex= 0;
            cbDisplay.SelectedIndex= 0;
        }

        public void Preload()
        {
            //Student student1 = new Student() {_firstName = "Jonathan", _lastName = "Reed", _CSIGrade = 77,
            //_GenEdGrade = 99};
            Student student = new Student("Joanthan", "Reed", 90, 77);
            students.Add(student);
            students.Add(new Student("Nami", "Cat burgler", 100, 99));
            students.Add(new Student("Luffy", "King of the Pirates", 100, 99));
            students.Add(new Student("Zoro", "Pirate Hunter", 67, 80));

        }
        public void DisplayToListBox()
        {
            // Use the .Clear() Method to clear all items from out listbox
            lbDisplay.Items.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                string firstName = students[i]._firstName;
                string lastName = students[i]._lastName;
                string fullName = firstName+ " " + lastName;
                lbDisplay.Items.Add(fullName);
            }
        }
        public void DisplayToComboBox()
        {
            // Use the .Clear() Method to clear all items from out listbox
            cbDisplay.Items.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                string firstName = students[i]._firstName;
                string lastName = students[i]._lastName;
                string fullName = firstName + " " + lastName;
                cbDisplay.Items.Add(fullName);
            }
        }

        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {
            string userInput = txtToAdd.Text;
            lbDisplay.Items.Add(userInput);

        }

        private void btnDisplayStudent_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndext = lbDisplay.SelectedIndex;

            if(selectedIndext == -1)
            {
                MessageBox.Show("Please select a Name from the List");
            }
            else
            {
                //Student selectedStudent = students[selectedIndext];
                //txtFirstName.Text = selectedStudent._firstName;
                //txtLastName.Text = selectedStudent._lastName;
                //txtCSIGrade.Text = selectedStudent._CSIGrade.ToString();
                //txtGenEd.Text = selectedStudent._GenEdGrade.ToString();
                DisplayStudentInformation(selectedStudent);
                //lbDisplay.SelectedIndex = selectedIndext;
            }
        }

        public void DisplayStudentInformation(Student student)
        {
            txtFirstName.Text = selectedStudent._firstName;
            txtLastName.Text = selectedStudent._lastName;
            txtCSIGrade.Text = selectedStudent._CSIGrade.ToString();
            txtGenEd.Text = selectedStudent._GenEdGrade.ToString();
        }

        private void btnAddStudnet_Click(object sender, RoutedEventArgs e)
        {
            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            string csi = txtCSIGrade.Text;
            string genEd = txtGenEd.Text;

            int genEdGrade = int.Parse(genEd);
            int csiGrade = int.Parse(csi);

            // i want to create a new instance of studet
            // add our text information to it
            // add it to out students list
            students.Add(new Student(fName, lName, csiGrade, genEdGrade));
            // then see the name appear in the list box
            DisplayToListBox();
        }

        private void btnRemoveStudent_Click(object sender, RoutedEventArgs e)
        {
            // remove by index
            //int selectedIndex = lbDisplay.SelectedIndex;

            //students.RemoveAt(selectedIndex);
            // remove by object
            int selectedIndex = lbDisplay.SelectedIndex;
            Student selectedStudent = students[selectedIndex];
            students.Remove(selectedStudent);
            DisplayToListBox();
        }

        private void lbDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = lbDisplay.SelectedIndex;
            selectedStudent= students[selectedIndex];

            DisplayStudentInformation(selectedStudent);
        }

        private void cbDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = cbDisplay.SelectedIndex;
            selectedStudent = students[selectedIndex];

            DisplayStudentInformation(selectedStudent);
        }
    }
}
