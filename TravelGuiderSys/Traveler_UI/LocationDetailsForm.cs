using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelGuiderLibrary;

namespace Traveler_UI
{
    public partial class LocationDetailsForm : Form
    {
        public LocationDetailsForm(LocationModel location)
        {
            InitializeComponent();
            DisplayLocationDetails(location);
        }

        private void DisplayLocationDetails(LocationModel location)
        {
            locationIdValueLbl.Text = location.LocationId.ToString();
            locationNameValueLbl.Text = location.LocationName;
            districtValueLbl.Text = location.District;
            budjetValueLbl.Text = location.Budjet.ToString();
            descriptionValueLbl.Text = location.Description;
        }

        private void planeBtn_Click(object sender, EventArgs e)
        {
            PlaneForm planeForm = new PlaneForm();
            planeForm.ShowDialog();
        }
    }
}
