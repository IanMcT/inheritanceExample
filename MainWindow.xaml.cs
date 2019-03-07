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
            Teen t1 = new Teen("Suzy", "Que", new DateTime(2003, 8, 9));
            MessageBox.Show(t1.ToString());
            Person p1 = new Person("Bob", "Smith", new DateTime(1966, 2, 28));
            MessageBox.Show(p1.ToString());
            p1.Move();
            MessageBox.Show(p1.ToString());
            MessageBox.Show("Hi","This is my caption");
            p1.Move();
            MessageBox.Show(p1.ToString());
            lblOutput.Content = p1.FullName + Environment.NewLine;
            lblOutput.Content += p1.getAge().ToString();
        }
    }

    public class Person
    {
        private string mFirstName;
        private string mLastName;
        private DateTime mBirthDay;
        private int mLocX;
        public string FullName
        {
            get
            {
                return mFirstName + " " + mLastName;
            }
        }
        public override string ToString()
        {
            return mLastName + ", " + mFirstName + " Location: " + mLocX.ToString();
        }
        public Person(string F, string L, DateTime B) {
            mFirstName = F;
            mLastName = L;
            mBirthDay = B;
            mLocX = 0;
        }
        public void Move()
        {
            Move(1);
        }

        public void Move(int d)
        {
            mLocX = mLocX + d;
        }
        public int getAge()
        {
            int age = DateTime.Now.Year - mBirthDay.Year;
            return age;
        }

    }
    public class Kid : Person
    {

        public Kid(string F, string L, DateTime B) : base(F, L, B)
        {
        }
    }
    public class Teen : Person
    {
        public Teen(string F, string L, DateTime B) : base(F, L, B)
        {
        }
    }
}
