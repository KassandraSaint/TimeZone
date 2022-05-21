using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeZone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            // Initializing city variable to hold a chosen option
            string city;
            // Checking if item was selected
            if (cityListBox.SelectedIndex != -1)
            {
                // Storing selected city in the variable
                city = cityListBox.SelectedItem.ToString();

                // Getting time zone
                switch (city)
                {
                    case "Honolulu":
                        timeZoneLabel.Text = "Hawaii-Aleutian";
                        break;
                    case "San Francisco":
                        timeZoneLabel.Text = "Pacific";
                        break;
                    case "Denver":
                        timeZoneLabel.Text = "Mountain";
                        break;
                    case "Minneapolis":
                        timeZoneLabel.Text = "Central";
                        break;
                    case "New York":
                        timeZoneLabel.Text = "Eastern";
                        break;
                }
            }
            else
            {
                // Showing a message 
                MessageBox.Show("Select a city.");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
