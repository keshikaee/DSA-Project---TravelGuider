using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traveler_UI
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        // Add Location Button Click Event  
        private void addLocationBtn_Click(object sender, EventArgs e)
        {
            addLocation addLocation = new addLocation();
            addLocation.Show();
        }


        private void getLocationBtn_Click_1(object sender, EventArgs e)
        {
            getLocation getLocation = new getLocation();
            getLocation.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
