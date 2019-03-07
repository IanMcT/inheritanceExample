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

namespace oopExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Person p1 = new Person("Bob", "Smith", new DateTime(1988, 8, 9));
            Teen t1 = new Teen("Will", "Smith", new DateTime(2005, 9, 8));
            t1.ShoeSize = 9;
            MessageBox.Show(t1.FullName + Environment.NewLine + t1.ShoeSize.ToString());
        }
    }
    /// <summary>
    /// Represents a person - has a name and birthday.
    /// </summary>
    public class Person
    {
        private string mFirstName;
        private string mLastName;
        private DateTime mBirthDay;
        /// <summary>
        /// Consists of the first and last name
        /// </summary>
        public string FullName
        {
            get
            {
                return mFirstName + " " + mLastName;
            }
        }
        /// <summary>
        /// Create a person
        /// </summary>
        /// <param name="firstName">string</param>
        /// <param name="lastName">string</param>
        /// <param name="birthDay">DateTime</param>
        public Person(string firstName, string lastName, DateTime birthDay)
        {
            mFirstName = firstName;
            mLastName = lastName;
            mBirthDay = birthDay;
        }
    }

    public class Teen : Person
    {
        private int shoesize;
        public int ShoeSize
            {
            get 
            {
                return shoesize;
            }
            set
            {
                shoesize = value;
            }
            }
        public Teen(string firstname, string lastname, DateTime birthday) : base (firstname, lastname, birthday)
        {
            
        }
    }
}
