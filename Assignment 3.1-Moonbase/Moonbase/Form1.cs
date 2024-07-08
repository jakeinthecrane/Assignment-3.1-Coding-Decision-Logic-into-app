using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Moonbase
{
    public partial class MoonbaseAssignment1 : Form
    {   // User position tracker class is declared. It is a read-only field.
        private readonly UserPositionTracker _positionTracker;
        //Array is declared in this class
        private Location[] locations;

        public MoonbaseAssignment1()

        {

            InitializeComponent();

            //UserPositionTracker instance is created and assigned it to _positionTracker
            //the mouseEventHandler is attatched to this.MouseMove.  the event handler assigns the- 
            //method Form_MouseMove as the EH.  Whenever the mouse moves over the form,- 
            //the method is called. 
            _positionTracker = new UserPositionTracker();
            this.MouseMove += new MouseEventHandler(Form_MouseMove);

            //Locations array initialized
            InitializeLocations();

        }
        //This method signature handles the MouseMove event.
        //_positionTracker is an instance of UserPosition which tracks the users position-
        // e.Location property of MouseEventArgs provides the X and Y coordinates. 
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            _positionTracker.UserPosition = e.Location;
        }
        //This method initializes the locations array
        private void InitializeLocations()
        {
            locations = new Location[] //this syntax initializes a new array of location objects
            {   //the array is initialized with four location objects loaded with 3 arguments each.
                new Location("Check in Lounge", "North", "Welcome to the North Side of the Moon"),
                new Location("Sauna Time", "West", "Welcome to the West Side of the Moon"),
                new Location("Salt Time", "East", "Welcome to the East Side of the Moon"),
                new Location("Weightless Zone", "South", "Welcome to the South Side of the Moon"),
            };

        }
        //This method displays information about the location.
        private void DisplayLocationInfo(int index)
        {
            if (index >= 0 && index < locations.Length) //this statement verifies if the index is within the-
            {                                           //valid range of the locations array.

                Location location = locations[index];  //this statement retrieves the object at the index.

                //This method displays a message depending which button is triggered. 
                MessageBox.Show($"Name:  {location.LocationName}\nDescription: {location.LocationDescription}\nBackground: {location.ScenicView}");
            }
        }

        //A strip menu I added to create a couple of drop down menu opions. 
        private void MinFacialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //A button I created to indicate a coupon code when clicked.  I also loaded an image in the property.
        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the code MOONDANCE for 20% off treatment ");


        }
        // The button North will open a new form when clicked, creating the check in lounge area.
        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            DisplayLocationInfo(0);
        }
        //The button West will open a third form when clicked, creating the sauna area.
        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            DisplayLocationInfo(1);
        }
        //The button East will open a fourth form when clicked, creating the salt room.
        private void Button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            DisplayLocationInfo(2);
        }
        //I changed the cursor to a hand icon when you hover over the button.
        private void Hand(object sender, EventArgs e)
        {
            button2.Cursor = Cursors.Hand;
        }
        //Here the South button directs you to form 5 when you click it.  
        private void Button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            DisplayLocationInfo(3);
        }

    }
    //Declaration of the tracker
    public class UserPositionTracker
    {
        //This field stores the users position
        private Point _userPosition;

        //This property provides access to the private field
        public Point UserPosition
        {
            //this property returns the value of the users position
            get { return _userPosition; }
            //this property allows you to assign a new value to the users position
            set
            {
                if (_userPosition != value) //the value is checked for differences with this statement
                {
                    _userPosition = value; //if the value is different, a new value is assigned
                    LogPosition(_userPosition); //this method logs the users position
                }
            }

        }
        //method declared LogPosition takes parameter "point" which represents X and Y coordinates
        //-this parameter is named "position"
        private void LogPosition(Point position)
        {
            //this variable holds the file path for the user logs. Position entries are stored here.
            string logPath = "User_position_log.txt";
            //string variable that formats user logs using x and y coordinates along with the date and time
            string logEntry = $"x;  {position.X},  Y: {position.Y},  Time: {DateTime.Now}"; //$ syntax-
            //allows embedding expressions inside curly braces.  

            //method which opens a file, appends the the specific string to the logEntry specified-
            //by logPath. If the file doesn't exist, it creates a new one.
            //the last property add a newline character at the end of logEntry-
            //so each entry is on a new line in the file.  
            File.AppendAllText(logPath, logEntry + Environment.NewLine);
        }
    }
       public class Location //Location class
    {
        //3 properties with public acccess modifiers and automatic getters and setters. They-
        //access and provide write access to the property. 
        public string ScenicView { get; set; }
        public string LocationName { get; set; }
        public string LocationDescription { get; set; }

        //The location constructor with 3 set parameters for each button when triggered. 
        public Location(string scenicView, string locationName, string locationDescription)
        { 
            ScenicView = scenicView;
            LocationName = locationName;
            LocationDescription = locationDescription;


        }

    }

}
