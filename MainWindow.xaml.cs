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

namespace Lecture_Example___Classes__Fields__Properties__and_Constructors_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List <Student> studentLists = new List<Student> ();
        public MainWindow()
        {
            InitializeComponent();
        //Declare and initialize 2 Movie objects in the MainWindow.cs. Assign values to each field using properties.
            Movie movie1 = new Movie();
            movie1.MovieName = "The Tomorrow War";
            movie1.MovieRating = 6.5;
            movie1.Director = "Chris Mckay";
            movie1.Year = 2021;

            Movie movie2 = new Movie();
            movie2.MovieName = "Ambulance";
            movie2.MovieRating = 6.1;
            movie2.Director = "Michael Bay";
            movie2.Year = 2022;


        //Create a new List<Student>. Initialize 2 Student objects. 1 with each constructor. Assign them to your list of students.;
            Student student1 = new Student("Victoria", "Brike", 110, 90);
            Student student2 = new Student("Emily", "Baker");

            studentLists.Add(student1);
            studentLists.Add(student2);


        //Declare and initialize 2 of YOUR class. Display information from one of these objects with either a message box or a rich text box.

            House house1 = new House(765000, "4", "2.5", 2700);
            rTbShowMessage.Text = (formatHouse(house1));

            House house2 = new House();
            house2.Price = 755000;
            house2.Room = "4";
            house2.Bathroom = "2.5";
            house2.SquareFt = 2665;
           

        }
        public string formatHouse(House house)
        {
            string formatHouse = house.price.ToString("c") + " - " + house.room +"Beds" +
                    " - " + house.bathroom +"Baths" + " - " + house.squareFt + "Sq.Ft";
            return formatHouse;
        }

    }
}
