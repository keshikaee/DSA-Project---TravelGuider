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
using System.Diagnostics;

namespace Traveler_UI
{
    public partial class getLocation : Form
    {
        public getLocation()
        {
            InitializeComponent();
        }

        private void seeBtn_Click(object sender, EventArgs e)
        {
            placesLstbox.Items.Clear();

            List<LocationModel> locations = GlobalVariables.LocationList.GetAllLocations();

            foreach (var location in locations)
            {
                placesLstbox.Items.Add(location.LocationName);
            }
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {

            placesLstbox.Items.Clear();

            bool sortByName = nameChkbox.Checked;
            bool sortByBudget = budjetChkbox.Checked;

            string algorithm = "BubbleSort";
            if (mergesrtChkbox.Checked)
                algorithm = "MergeSort";
            else if (quicksrtChkbox.Checked)
                algorithm = "QuickSort";

            Stopwatch stopwatch = Stopwatch.StartNew();

            List<LocationModel> sortedLocations = GlobalVariables.LocationList.GetSortedLocations(sortByName, sortByBudget, algorithm);

            stopwatch.Stop();
            executionTimeLbl.Text = $"{stopwatch.ElapsedTicks} ticks";

            foreach (var location in sortedLocations)
            {
                placesLstbox.Items.Add(location.LocationName);
            }
        }

        private void getBtn_Click(object sender, EventArgs e)
        {
            // Clear the list box before adding new items
            placesLstbox.Items.Clear();

            // Get the district and budget range from the text boxes
            string district = yourDistrictTxtbox.Text.Trim();
            int minBudget = int.TryParse(yourBudjetminTxtbox.Text.Trim(), out int min) ? min : 0;
            int maxBudget = int.TryParse(yourBudjetmaxTxtbox.Text.Trim(), out int max) ? max : int.MaxValue;

            // Get matching locations from the global list
            List<LocationModel> matchingLocations = GlobalVariables.LocationList.GetLocationsByDistrictAndBudgetRange(district, minBudget, maxBudget);

            // Add each location name to the list box
            foreach (var location in matchingLocations)
            {
                placesLstbox.Items.Add(location.LocationName);
            }
        }

        private void seemoreBtn_Click(object sender, EventArgs e)
        {
            if (placesLstbox.SelectedItem != null)
            {
                string selectedLocationName = placesLstbox.SelectedItem.ToString();
                LocationModel selectedLocation = GlobalVariables.LocationList.GetAllLocations()
                    .FirstOrDefault(loc => loc.LocationName == selectedLocationName);

                if (selectedLocation != null)
                {
                    LocationDetailsForm detailsForm = new LocationDetailsForm(selectedLocation);
                    detailsForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Location not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a location from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
